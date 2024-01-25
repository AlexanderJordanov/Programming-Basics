using Microsoft.VisualBasic;
using System;

namespace NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            switch (flowerType)
            {
                case "Roses": price = 5; break;
                case "Dahlias": price = 3.8; break;
                case "Tulips": price = 2.8; break;
                case "Narcissus": price = 3; break;
                case "Gladiolus": price = 2.5; break;
            }

            double totalPrice = price * flowerCount;

            if (flowerType == "Roses" && flowerCount > 80)
            {
                totalPrice = 0.9 * totalPrice;
            }
            else if (flowerType == "Dahlias" && flowerCount > 90)
            {
                totalPrice = 0.85 * totalPrice;
            }
            else if (flowerType == "Tulips" && flowerCount > 80)
            {
                totalPrice = 0.85 * totalPrice;
            }
            else if (flowerType == "Narcissus" && flowerCount < 120)
            { 
                totalPrice = totalPrice * 0.15 + totalPrice;
            }
            else if (flowerType == "Gladiolus" && flowerCount < 80)
            {
                totalPrice = totalPrice * 0.2 + totalPrice;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {budget - totalPrice:f2} leva left.");
            }

            else
            {
                Console.WriteLine($"Not enough money, you need {totalPrice - budget:f2} leva more.");
            }
        }
    }
}
