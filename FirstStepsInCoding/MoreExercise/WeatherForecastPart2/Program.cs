﻿using System;

namespace WeatherForecastPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());

            if (degrees > 35)
            {
                Console.WriteLine("unknown");
            }
            else if (degrees >= 26)
            {
                Console.WriteLine("Hot");
            }
            else if (degrees > 20)
            {
                Console.WriteLine("Warm");
            }
            else if (degrees >= 15)
            {
                Console.WriteLine("Mild");
            }
            else if (degrees >= 12)
            {
                Console.WriteLine("Cool");
            }
            else if (degrees >= 5)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }



        }
    }
}
