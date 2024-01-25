using System;

namespace HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartamentPrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50 * days;
                apartamentPrice = 65 * days;
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20 * days;
                apartamentPrice = 68.70 * days;
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76 * days;
                apartamentPrice = 77 * days;
            }

            if ((days > 7 && days <= 14) && (month == "May" || month == "October"))
            {
                studioPrice = 0.95 * studioPrice;
            }

            else if (days > 14)
            {
                apartamentPrice = 0.9 * apartamentPrice;

                if (month == "May" || month == "October")
                {
                    studioPrice = 0.7 * studioPrice;
                }
                else if (month == "June" || month == "September")
                {
                    studioPrice = 0.8 * studioPrice;
                }
            }

            Console.WriteLine($"Apartment: {apartamentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
