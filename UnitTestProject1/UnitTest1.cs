using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pose;
using Shim = Pose.Shim;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private DateTime _now;

        [TestInitialize]
        public void Setup()
        {
            _now = new DateTime(2018, 3, 21);
        }

        [TestMethod]
        public void TestYesterday()
        {
            Assert.IsTrue(DateService.WasYesterDay(new DateTime(2018, 3, 20), _now));
        }

        [TestMethod]
        public void TestYesterdayEvening()
        {
            
            Assert.IsTrue(DateService.WasYesterDay(new DateTime(2018, 3, 20, 23, 0, 0), _now));
        }
    }
}
