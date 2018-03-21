using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a date");
            DateTime.TryParse(Console.ReadLine(), out var date);
            Console.WriteLine($"WasYesterDay returned {(DateTime.Today - date).Days == 1}");
            Console.ReadLine();
        }
    }
}
