using System;

namespace Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
            

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200) { p1 ++; }
                else if (num >= 200 && num < 400) { p2 ++; }
                else if (num >= 400 && num < 600) { p3 ++; }
                else if (num >= 600 && num < 800) { p4 ++; }
                else if (num >= 800) { p5 ++; }
            }

            
            double c1 = 100.0 * p1 / n;
            double c2 = 100.0 * p2 / n;
            double c3 = 100.0 * p3 / n;
            double c4 = 100.0 * p4 / n;
            double c5 = 100.0 * p5 / n;

            Console.WriteLine($"{c1:f2}%");
            Console.WriteLine($"{c2:f2}%");
            Console.WriteLine($"{c3:f2}%");
            Console.WriteLine($"{c4:f2}%");
            Console.WriteLine($"{c5:f2}%");

        }
    }
}
