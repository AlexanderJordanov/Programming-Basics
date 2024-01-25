using System;

namespace BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());

            double shoes = tax * 0.6;
            double kit = shoes * 0.8;
            double ball = kit * 0.25;
            double accessories = ball * 0.2;
            Console.WriteLine(tax+shoes+kit+ball+accessories);
        }
    }
}
