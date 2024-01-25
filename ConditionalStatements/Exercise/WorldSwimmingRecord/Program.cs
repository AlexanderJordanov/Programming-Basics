using System;

namespace WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine()); 
            double timePerMeterInSeconds = double.Parse(Console.ReadLine());

            double totalTime = distanceInMeters * timePerMeterInSeconds + Math.Floor(distanceInMeters / 15) * 12.5;

            if (totalTime < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - recordInSeconds:f2} seconds slower.");
            }
        }
    }
}
