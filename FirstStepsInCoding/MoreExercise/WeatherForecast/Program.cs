using System;

namespace WeatherForecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string weather = Console.ReadLine();
            if (weather == "sunny")
            {
                Console.WriteLine($"It's warm outside!");
            }
            else
            {
                Console.Write($"It's cold outside!");
            }
        }
    }
}
