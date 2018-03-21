using System;

namespace ConsoleApp1
{
    public class DateService
    {
        public static bool WasYesterDay(DateTime date)
        {
            return (DateTime.Today - date).Days == 1;
        }
    }
}