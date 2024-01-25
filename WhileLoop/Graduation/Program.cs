using System;
using System.Diagnostics;

namespace Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double grade = 1;
            int badGrades = 0;
            double totalGrade = 0;

            while (grade <= 12)
            {
                double yearGrade = double.Parse(Console.ReadLine());

                if (yearGrade < 4)
                {
                    badGrades++;
                    if (badGrades < 2)
                    { 
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        break;
                    }

                }
                totalGrade += yearGrade;
                grade++;
            }
            if (grade >= 12)
            { 
                double averageGrade = totalGrade / 12;
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }

        }
    }
}

