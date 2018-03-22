using System;
using ConsoleApp1;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    class ClockServiceForTesting : IClockService
    {
        public DateTime Now => new DateTime(2018, 3, 21);
    }

    [TestClass]
    public class UnitTest1
    {
        private ServiceProvider _serviceProvider;
        private DateService _dateService;
        
        [TestInitialize]
        public void Setup()
        {
            _serviceProvider = new ServiceCollection()
                .AddSingleton<IClockService, ClockServiceForTesting>()
                .AddSingleton<DateService>()
                .BuildServiceProvider();

            _dateService = _serviceProvider.GetService<DateService>();
        }

        [TestMethod]
        public void TestYesterday()
        {
            Assert.IsTrue(_dateService.WasYesterDay(new DateTime(2018, 3, 20)));
        }

        [TestMethod]
        public void TestYesterdayEvening()
        {

            Assert.IsTrue(_dateService.WasYesterDay(new DateTime(2018, 3, 20, 23, 0, 0)));
        }
    }
}
