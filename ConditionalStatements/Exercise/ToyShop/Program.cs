using System;

namespace ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceOfTrip = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());

            int numberOfToys = puzzle + doll + bear + minion + truck;
            double priceOfToys = puzzle * 2.6 + doll * 3 + bear * 4.1 + minion * 8.2 + truck * 2;

            if ( numberOfToys >= 50 )
            {
                double discount = priceOfToys * 0.25;
                priceOfToys = priceOfToys - discount;
            }
            double rent = priceOfToys * 0.1;
            double finalPrice = priceOfToys - rent;
            if (finalPrice >= priceOfTrip)
            {
                Console.WriteLine($"Yes! {finalPrice - priceOfTrip:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceOfTrip - finalPrice:f2} lv needed.");
            }
        }
    }
}
