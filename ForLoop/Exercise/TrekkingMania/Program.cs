using System;
using System.Xml.Schema;

namespace TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
            double n1 = 0, n2 = 0, n3 = 0, n4 = 0, n5 = 0;
            int totalPeople = 0;
            for (int i = 0; i < groups; i++)
            {
                int peopleInEachGroup = int.Parse(Console.ReadLine());

                if (peopleInEachGroup <= 5) { p1 += peopleInEachGroup; }
                else if (peopleInEachGroup >= 6 && peopleInEachGroup <= 12) { p2 += peopleInEachGroup; }
                else if (peopleInEachGroup >= 13 && peopleInEachGroup <= 25) { p3 += peopleInEachGroup; }
                else if (peopleInEachGroup >= 26 && peopleInEachGroup <= 40) { p4 += peopleInEachGroup; }
                else if (peopleInEachGroup >= 41) { p5 +=peopleInEachGroup; }

                totalPeople += peopleInEachGroup;
            }
            n1 = 100.0 * p1 / totalPeople;
            n2 = 100.0 * p2 / totalPeople; 
            n3 = 100.0 * p3 / totalPeople; 
            n4 = 100.0 * p4 / totalPeople; 
            n5 = 100.0 * p5 / totalPeople;

            Console.WriteLine($"{n1:f2}%");
            Console.WriteLine($"{n2:f2}%");
            Console.WriteLine($"{n3:f2}%");
            Console.WriteLine($"{n4:f2}%");
            Console.WriteLine($"{n5:f2}%");

        }
    }
}
