using System;

namespace CelsiusToFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            Console.WriteLine($"{celsius*1.8+32:f2}");
        }
    }
}
