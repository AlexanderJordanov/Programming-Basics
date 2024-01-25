using System;

namespace CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int totalTicketsCount = 0;
            int studentTicketsCount = 0;
            int standardTicketsCount = 0;
            int kidTicketsCount = 0;

            while (movieName != "Finish")
            {
                int capacity = int.Parse(Console.ReadLine());
                int soldTickets = 0;
                string ticketType = Console.ReadLine();

                while (ticketType != "End")
                {
                    if (ticketType == "student") { studentTicketsCount++; }
                    else if (ticketType == "standard") { standardTicketsCount++; }
                    else if (ticketType == "kid") { kidTicketsCount++; }
                    soldTickets++;
                    if (soldTickets == capacity) { break; }
                    ticketType = Console.ReadLine();
                }
                totalTicketsCount += soldTickets;

                double fillPercentage = 100.0 * soldTickets / capacity;
                Console.WriteLine($"{movieName} - {fillPercentage:f2}% full.");
                movieName = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTicketsCount}");
            Console.WriteLine($"{100.0 * studentTicketsCount / totalTicketsCount:f2}% student tickets.");
            Console.WriteLine($"{100.0 * standardTicketsCount / totalTicketsCount:f2}% standard tickets.");
            Console.WriteLine($"{100.0 * kidTicketsCount / totalTicketsCount:f2}% kids tickets.");
        }
    }
}
