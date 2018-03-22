using System;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var serviceProvider = new ServiceCollection()
            //    .AddSingleton<IClockService, ClockService>()
            //    .AddSingleton<DateService>()
            //    .BuildServiceProvider();

            //var dateService = serviceProvider.GetService<DateService>();
            var dateService = new DateService(new ClockService());

            while (true)
            {
                Console.WriteLine("Enter a date");
                DateTime.TryParse(Console.ReadLine(), out var date);
                Console.WriteLine($"WasYesterDay returned {dateService.WasYesterDay(date)}");
            }
        }
    }
}
