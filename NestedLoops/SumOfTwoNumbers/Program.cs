using System;
using System.Reflection;

namespace SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            bool found = false;
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    int sum = i + j;
                    counter++;
                    if (sum == magicNumber) 
                    {  
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNumber})"); 
                        found = true;
                        break;
                    }
                }
                if (found) { break; }
            }
            if (!found) { Console.WriteLine($"{counter} combinations - neither equals {magicNumber}"); }
        }
    }
}
