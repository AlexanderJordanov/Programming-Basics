using System;

namespace FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
             
            double capacity = (length * height * width) * 0.001;
            Console.WriteLine(capacity * (1 - (percent * 0.01)));
        }
    }
}
