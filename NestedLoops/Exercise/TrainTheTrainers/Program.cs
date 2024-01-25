using System;

namespace TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int judges = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double absTotal = 0;
           
            int counter = 0;
            while (input != "Finish")
            {
                double total = 0;
                double average = 0;
                for (int i = 0; i < judges; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    total += grade;
                }
                average = total / judges;
                Console.WriteLine($"{input} - {average:f2}.");

                counter++;
                absTotal += total;
                
                input = Console.ReadLine();
            }
            double absTotalAverage = absTotal / (counter * judges);
            Console.WriteLine($"Student's final assessment is {absTotalAverage:f2}.");
        }
    }
}
