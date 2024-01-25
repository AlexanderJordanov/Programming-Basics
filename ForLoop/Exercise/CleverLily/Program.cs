using System;

namespace CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int pricePerToy = int.Parse(Console.ReadLine());

            double evenBirthday = 0;
            int oddBirthday = 0;
            int moneyPerEvenBirthday = 10;
            for (int i = 1; i <= age; i++) 
            { 
                if (i % 2 ==0)
                {
                    evenBirthday += moneyPerEvenBirthday;
                    evenBirthday -= 1;
                    moneyPerEvenBirthday += 10;
                }
                else
                {
                    oddBirthday += pricePerToy;
                }
            }

            double totalMoney = evenBirthday + oddBirthday;

            if (totalMoney >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {totalMoney - washingMachinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachinePrice - totalMoney:f2}");
            }

        }
    }
}
