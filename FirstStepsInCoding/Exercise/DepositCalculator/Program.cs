using System;

namespace DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());
            Console.WriteLine(sum + term * (sum * interest * 0.01) / 12);
        }
    }
}
