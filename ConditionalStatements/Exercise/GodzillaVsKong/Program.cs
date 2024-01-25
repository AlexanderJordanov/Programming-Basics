using System;

namespace GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            int countOfExtras = int.Parse(Console.ReadLine());
            double priceOfClothingPerExtra = double.Parse(Console.ReadLine());

            double priceOfDecor = 0.1 * movieBudget;
            double totalPriceOfClothing = priceOfClothingPerExtra * countOfExtras;
            if (countOfExtras > 150)
            {
                totalPriceOfClothing = totalPriceOfClothing * 0.9;
            }
            double totalMoviePrice = totalPriceOfClothing + priceOfDecor;
            if (totalMoviePrice > movieBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalMoviePrice - movieBudget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {movieBudget - totalMoviePrice:f2} leva left.");
            }
                
        }
    }
}
