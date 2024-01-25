using System;

namespace TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournamentCount = int.Parse(Console.ReadLine());
            int initialPoints = int.Parse(Console.ReadLine());
            int winsCount = 0;
            int tournamentsPoints = 0;
            for (int i = 0; i < tournamentCount; i++)
            {
                string position = Console.ReadLine();

                if (position == "W") { winsCount++; tournamentsPoints += 2000; }
                else if (position == "F") { tournamentsPoints += 1200; }
                else if ( position == "SF") { tournamentsPoints += 720; }
            }
            int totalPoints = tournamentsPoints + initialPoints;
            int averagePoints = tournamentsPoints / tournamentCount;
            double wonPercentage = 100.0 * winsCount / tournamentCount;

            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{wonPercentage:f2}%");
        }
    }
}
