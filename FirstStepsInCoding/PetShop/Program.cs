using System;

namespace PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());
            double cena = dogFood * 2.50 + catFood * 4;
            Console.WriteLine(cena);
            //Console.WriteLine($"{dogFood * 2.50 + catFood *4} lv.");
        }
    }
}
