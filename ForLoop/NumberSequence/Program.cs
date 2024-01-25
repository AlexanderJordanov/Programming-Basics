using System;

namespace NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberAmount = int.Parse(Console.ReadLine());

            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < numberAmount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < min) { min = number; }
                if (number > max) { max = number; }
            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
