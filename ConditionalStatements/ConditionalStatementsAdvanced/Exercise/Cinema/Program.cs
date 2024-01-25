using System;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projectType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double income = 0;
            if (projectType == "Premiere") { income = rows * colums * 12; }
            else if (projectType == "Normal") { income = rows * colums * 7.5; }
            else if (projectType == "Discount") { income = rows * colums * 5; }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
