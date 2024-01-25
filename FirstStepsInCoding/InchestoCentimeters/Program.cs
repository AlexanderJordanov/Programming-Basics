using System;

namespace InchestoCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inches = int.Parse(Console.ReadLine());
            double santimeters = inches * 2.54;
            Console.WriteLine(santimeters);
        }
    }
}
