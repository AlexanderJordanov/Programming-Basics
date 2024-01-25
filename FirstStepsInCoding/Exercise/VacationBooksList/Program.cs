using System;

namespace VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPages = int.Parse(Console.ReadLine()); 
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());   
            Console.WriteLine((totalPages / pagesPerHour) / days);
        }
    }
}
