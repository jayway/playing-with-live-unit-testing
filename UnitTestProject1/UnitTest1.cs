 using System;
 using ConsoleApp1;
 using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestYesterday()
        {
            Assert.IsTrue(DateService.WasYesterDay(new DateTime(2018, 3, 20)));
        }

        [TestMethod]
        public void TestYesterdayEvening()
        {
            Assert.IsTrue(DateService.WasYesterDay(new DateTime(2018, 3, 20, 23, 0, 0)));
        }
    }
}
