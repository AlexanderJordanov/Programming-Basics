using System;

namespace Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int judges = int.Parse(Console.ReadLine());
            double totalJudgePoints = 0;
            for (int i = 0; i < judges && points <=1250.5; i++)
            {
                string judgeName = Console.ReadLine();
                double judgePoints = double.Parse(Console.ReadLine());
                
                points += (judgeName.Length * judgePoints)/2;
            }
            if ( points > 1250.5) 
            { 
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:f1}!"); 
            }
            else { Console.WriteLine($"Sorry, {actorName} you need {1250.5 - points:f1} more!"); }
        }
    }
}
