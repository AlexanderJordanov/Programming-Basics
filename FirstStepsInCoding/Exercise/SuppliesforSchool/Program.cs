using System;

namespace SuppliesforSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());    
            int preparation = int.Parse(Console.ReadLine()); 
            int discount = int.Parse(Console.ReadLine());
            double price = pens * 5.8 + markers * 7.2 + preparation * 1.2;
            Console.WriteLine(price - (price * discount * 0.01));
        }
    }
}
