using System;

namespace Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mackerelPricePerKilo = double.Parse(Console.ReadLine());
            double sprinklePricePerKilo = double.Parse(Console.ReadLine());
            double bonitoKilo = double.Parse(Console.ReadLine());
            double safridKilo = double.Parse(Console.ReadLine());
            int musslesKilo = int.Parse(Console.ReadLine());

            double bonitoTotalPrice = (mackerelPricePerKilo + mackerelPricePerKilo * 0.6) * bonitoKilo;
            double safridTotalPrice = (sprinklePricePerKilo + sprinklePricePerKilo * 0.8) * safridKilo;
            double musslesTotalPrice = musslesKilo * 7.5;

            Console.WriteLine($"{musslesTotalPrice + safridTotalPrice + bonitoTotalPrice:f2}");

        }
    }
}
