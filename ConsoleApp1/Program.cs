using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a date");
                DateTime.TryParse(Console.ReadLine(), out var date);
                Console.WriteLine(date);
                Console.WriteLine($"WasYesterDay returned {DateService.WasYesterDay(date)}");
            }
            
        }
    }
}
