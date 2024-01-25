using System;

namespace SpeedInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rate = double.Parse(Console.ReadLine());

            if (rate <= 10) 
            {
                Console.WriteLine("slow");
            }
            else if (rate <= 50)
            {
                Console.WriteLine("average");
            }
            else if ( rate <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (rate <= 1000)
            {
                 Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }

        }
    }
}
