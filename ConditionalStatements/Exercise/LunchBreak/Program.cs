using System;

namespace LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine();
            int episodeDuration = int.Parse(Console.ReadLine());
            int lunchBreakDuration = int.Parse(Console.ReadLine());

            double timeRemaining = lunchBreakDuration - (lunchBreakDuration * 0.125 + lunchBreakDuration * 0.25);   

            if (timeRemaining >= episodeDuration) 
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(timeRemaining - episodeDuration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(episodeDuration - timeRemaining)} more minutes.");
            }
        }
    }
}
