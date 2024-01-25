using System;

namespace VegetableMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vegetablesPricePerKilo = double.Parse(Console.ReadLine());
            double fruitsPricePerKilo = double.Parse(Console.ReadLine());

            int vegetablesAmount = int.Parse(Console.ReadLine());
            int fruitsAmount = int.Parse(Console.ReadLine());

            double totalPriceInLeva = vegetablesPricePerKilo*vegetablesAmount + fruitsPricePerKilo*fruitsAmount;
            Console.WriteLine($"{totalPriceInLeva / 1.94:f2}");
        }
    }
}
