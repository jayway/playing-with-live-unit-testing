using System;
using ConsoleApp1;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Mock<IClockService> _clockServiceMock = new Mock<IClockService>();
        private DateService _dateService;
        
        [TestInitialize]
        public void Setup()
        {
            _clockServiceMock.Setup(c => c.Now).Returns(new DateTime(2018, 3, 21));
            _dateService = new DateService(_clockServiceMock.Object);
        }

        [TestMethod]
        public void TestYesterday()
        {
            Assert.IsTrue(_dateService.WasYesterDay(new DateTime(2018, 3, 20)));
            _clockServiceMock.VerifyGet(c => c.Now, Times.Exactly(1));
        }

        [TestMethod]
        public void TestYesterdayEvening()
        {
            Assert.IsTrue(_dateService.WasYesterDay(new DateTime(2018, 3, 20, 23, 0, 0)));
            _clockServiceMock.VerifyGet(c => c.Now, Times.Exactly(1));
        }

        [TestMethod]
        public void TestFarIntoTheFuture1()
        {
            _clockServiceMock.Setup(c => c.Now).Returns(DateTime.MaxValue);
            Assert.IsFalse(_dateService.WasYesterDay(new DateTime(2018, 3, 20)));
            _clockServiceMock.VerifyGet(c => c.Now, Times.Exactly(1));
        }

        [TestMethod]
        public void TestFarIntoTheFuture2()
        {
            _clockServiceMock.Setup(c => c.Now).Returns(DateTime.MaxValue);
            Assert.IsTrue(_dateService.WasYesterDay(new DateTime(9999, 12, 30)));
            _clockServiceMock.VerifyGet(c => c.Now, Times.Exactly(1));
        }

        [TestMethod]
        public void TestTheBeginningOfTime()
        {
            _clockServiceMock.Setup(c => c.Now).Returns(DateTime.MinValue);
            Assert.IsFalse(_dateService.WasYesterDay(new DateTime(2018, 3, 20)));
            _clockServiceMock.VerifyGet(c => c.Now, Times.Exactly(1));
        }
    }
}
