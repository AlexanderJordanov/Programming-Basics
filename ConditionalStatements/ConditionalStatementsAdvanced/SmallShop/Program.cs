using System;

namespace SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            //град / продукт  coffee  water    beer    sweets  peanuts
            //Sofia            0.50    0.80    1.20    1.45    1.60
            //Plovdiv          0.40    0.70    1.15    1.30    1.50
            //Varna            0.45    0.70    1.10    1.35    1.55

            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            
           if (city == "Sofa")
            {
                if (product == "coffee") { Console.WriteLine(quantity * 0.5); }
                else if (product == "water") { Console.WriteLine(quantity * 0.8); }
                else if (product == "beer") { Console.WriteLine(quantity * 1.2); }
                else if (product == "sweets") { Console.WriteLine(quantity * 1.45); }
                else if (product == "peanuts") { Console.WriteLine(quantity * 1.6); }
            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee") { Console.WriteLine(quantity * 0.4); }
                else if (product == "water") { Console.WriteLine(quantity * 0.7); }
                else if (product == "beer") { Console.WriteLine(quantity * 1.15); }
                else if (product == "sweets") { Console.WriteLine(quantity * 1.30); }
                else if (product == "peanuts") { Console.WriteLine(quantity * 1.5); }
            }
            if (city == "Varna")
            {
                if (product == "coffee") { Console.WriteLine(quantity * 0.45); }
                else if (product == "water") { Console.WriteLine(quantity * 0.7); }
                else if (product == "beer") { Console.WriteLine(quantity * 1.1); }
                else if (product == "sweets") { Console.WriteLine(quantity * 1.35); }
                else if (product == "peanuts") { Console.WriteLine(quantity * 1.55); }
            }
        }
    }
}
