using System;

namespace Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string vacationType = "";
            double vacationPrice = 0;
            if (season == "summer") { vacationType = "Camp"; }
            else { vacationType = "Hotel"; }

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    vacationPrice = 0.3 * budget;
                }
                else
                {
                    vacationPrice = 0.7 * budget;
                }

            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    vacationPrice = 0.4 * budget;
                }
                else
                {
                    vacationPrice = 0.8 * budget;
                }
            }
            else
            {
                destination = "Europe";
                vacationType = "Hotel";
                vacationPrice = 0.9 * budget;
            }

           

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{vacationType} - {vacationPrice:f2}");



        }
    }
}
