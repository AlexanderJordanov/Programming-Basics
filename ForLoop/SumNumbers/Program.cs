using System;

namespace SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberAmount = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= numberAmount; i++) 
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
