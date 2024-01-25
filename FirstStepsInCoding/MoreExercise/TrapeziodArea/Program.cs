using System;

namespace TrapeziodArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());    
            double sideB = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine($"{((sideA + sideB)*h)/2:f2}");
        }
    }
}
