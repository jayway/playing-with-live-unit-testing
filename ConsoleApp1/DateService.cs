using System;

namespace ConsoleApp1
{
    public class DateService
    {
        public static bool WasYesterDay(DateTime date, DateTime now)
        {
            return (now.Date - date.Date).Days == 1;
        }
    }
}