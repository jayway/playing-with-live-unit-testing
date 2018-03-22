using System;

namespace ConsoleApp1
{
    public class DateService
    {
        private readonly IClockService _clockService;

        public DateService(IClockService clockService)
        {
            _clockService = clockService;
        }

        public bool WasYesterDay(DateTime date)
        {
            return (_clockService.Now.Date - date.Date).Days == 1;
        }
    }
}