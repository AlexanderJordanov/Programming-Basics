using System;

namespace TriangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine($"{(side * height) / 2:f2}");
        }
    }
}
