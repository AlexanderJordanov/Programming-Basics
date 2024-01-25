using System;

namespace Time_15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int minutesAfter = minutes + 15;

            if (minutesAfter >= 60)
            {
                hours = hours + 1;
                minutesAfter = minutesAfter - 60;
            }
            if ( hours > 23) 
            {
                hours = 0;
            }
            if (minutesAfter< 10)
            {
                Console.WriteLine($"{hours}:0{minutesAfter}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutesAfter}");
            }
        }
    }
}
