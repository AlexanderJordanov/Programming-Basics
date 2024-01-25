using System;

namespace SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string grade = Console.ReadLine();

            int nights = days - 1;
            double visitPrice = 0;

            if (days < 10)
            {
                if (typeOfRoom == "room for one person")
                {
                    visitPrice = 18 * nights;
                }
                else if (typeOfRoom == "apartment")
                {
                    visitPrice = (25 * nights) * 0.7;
                }
                else if (typeOfRoom == "president apartment")
                {
                    visitPrice = (35 * nights) * 0.9;
                }
            }
            else if (days >= 10 && days <=15)
            {
                if (typeOfRoom == "room for one person")
                {
                    visitPrice = 18 * nights;
                }
                else if (typeOfRoom == "apartment")
                {
                    visitPrice = (25 * nights) * 0.65;
                }
                else if (typeOfRoom == "president apartment")
                {
                    visitPrice = (35 * nights) * 0.85;
                }
            }
            else if (days > 15)
            {
                if (typeOfRoom == "room for one person")
                {
                    visitPrice = 18 * nights;
                }
                else if (typeOfRoom == "apartment")
                {
                    visitPrice = (25 * nights) * 0.5;
                }
                else if (typeOfRoom == "president apartment")
                {
                    visitPrice = (35 * nights) * 0.8;
                }
            }

            if (grade == "positive") { visitPrice = visitPrice * 1.25; }
            else { visitPrice = visitPrice * 0.9; }

            Console.WriteLine($"{visitPrice:f2}");
        }
    }
}
