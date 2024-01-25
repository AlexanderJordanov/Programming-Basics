using System;

namespace YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double price = area * 7.61;
            double finalPrice = price - price*0.18;
            double discount = price - finalPrice;
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount}lv.");

        }
    }
}
