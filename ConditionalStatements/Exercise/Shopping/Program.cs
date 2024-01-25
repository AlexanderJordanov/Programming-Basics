using System;

namespace Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberVideoCard = int.Parse(Console.ReadLine());
            int numberProcessor = int.Parse(Console.ReadLine());
            int numberRam = int.Parse(Console.ReadLine());

            double priceVideoCard = numberVideoCard * 250;
            double priceProcessor = priceVideoCard * 0.35 * numberProcessor;
            double priceRam = priceVideoCard * 0.1 * numberRam;
            double totalPrice = priceVideoCard + priceProcessor + priceRam;

            if (numberVideoCard > numberProcessor)
            {
                totalPrice = totalPrice * 0.85;
            }
            if (budget >= totalPrice)
            {
                Console.WriteLine($"You have {budget - totalPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva more!");
            }
        }
    }
}
