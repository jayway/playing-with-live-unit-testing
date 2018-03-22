using System;

namespace ConsoleApp1
{
    public interface IClockService
    {
        DateTime Now { get; }
    }
    public class ClockService : IClockService
    {
        public DateTime Now => DateTime.Now;
    }
}