﻿using System;

namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < tabs && salary > 0; i++) 
            {
            
                string openedTab = Console.ReadLine();

                if (openedTab == "Facebook") { salary -= 150; }
                else if (openedTab == "Instagram") { salary -= 100; }
                else if (openedTab == "Reddit") { salary -= 50; }


            
            }
            if (salary <= 0) { Console.WriteLine("You have lost your salary."); }
            else { Console.WriteLine(salary); }

        }
    }
}
