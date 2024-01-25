using System;

namespace Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            
            while (destination != "End") 
            {
                double cost = double.Parse(Console.ReadLine());
                double totalMoney = 0;

                while (totalMoney < cost)
                {
                    double savedMoney = double.Parse(Console.ReadLine());
                    totalMoney += savedMoney;
                    
                }
                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
        }
    }
}
