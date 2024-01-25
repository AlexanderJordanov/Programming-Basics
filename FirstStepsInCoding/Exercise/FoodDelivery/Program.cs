using System;

namespace FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());   
            int fishMenu = int.Parse(Console.ReadLine());   
            int veggyMenu = int.Parse(Console.ReadLine());

            double priceOfMenus = chickenMenu * 10.35 + fishMenu * 12.4 + veggyMenu * 8.15;
            Console.WriteLine(priceOfMenus + (priceOfMenus * 0.2) + 2.5);
        }
    }
}
