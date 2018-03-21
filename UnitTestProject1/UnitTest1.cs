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
        private Shim _todayShim;

        [TestInitialize]
        public void Setup()
        {
            _todayShim = Shim.Replace(() => DateTime.Today).With(() => new DateTime(2018, 3, 21));
        }

        [TestMethod]
        public void TestYesterday()
        {
            bool? result = null;
            PoseContext.Isolate(() =>
                {
                    result = DateService.WasYesterDay(new DateTime(2018, 3, 20));
                }, _todayShim);
            Assert.IsTrue(result != null && result.Value);
        }

        [TestMethod]
        public void TestYesterdayEvening()
        {
            bool? result = null;
            PoseContext.Isolate(() =>
            {
                result = DateService.WasYesterDay(new DateTime(2018, 3, 20, 23, 0, 0));
            }, _todayShim);
            Assert.IsTrue(result!=null && result.Value);
        }
    }
}
