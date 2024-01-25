using System;

namespace FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermanCount = int.Parse(Console.ReadLine());

            double shipRent = 0;

            if (season == "Spring") { shipRent = 3000; }
            else if (season == "Summer" || season == "Autumn") { shipRent = 4200; }
            else if (season == "Winter") { shipRent = 2600; }

            if (fishermanCount <= 6) { shipRent = 0.9 * shipRent; }
            else if (fishermanCount >= 7 && fishermanCount <= 11) { shipRent = 0.85 * shipRent; } 
            else if (fishermanCount > 12) { shipRent = 0.75 * shipRent; }

            if (fishermanCount % 2 == 0 && season != "Autumn") { shipRent = 0.95 * shipRent; }

            if (budget >= shipRent)
            {
                Console.WriteLine($"Yes! You have {budget - shipRent:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {shipRent - budget:f2} leva.");
            }
        }
    }
}
