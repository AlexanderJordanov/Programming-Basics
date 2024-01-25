using System;

namespace OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double output = 0;
            if (operation == "+")
            {
                output = number1 + number2;
                if (output % 2 == 0) { Console.WriteLine($"{number1} + {number2} = {output} - even"); }
                else { Console.WriteLine($"{number1} + {number2} = {output} - odd"); }
            }
            else if (operation == "-")
            {
                output = number1 - number2;
                if (output % 2 == 0) { Console.WriteLine($"{number1} - {number2} = {output} - even"); }
                else { Console.WriteLine($"{number1} - {number2} = {output} - odd"); }
            }
            else if (operation == "*")
            {
                output = number1 * number2;
                if (output % 2 == 0) { Console.WriteLine($"{number1} * {number2} = {output} - even"); }
                else { Console.WriteLine($"{number1} * {number2} = {output} - odd"); }
            }

            else if (operation == "/")
            {
              
                if (number2 == 0) { Console.WriteLine($"Cannot divide {number1} by zero"); }
                else { output = 1.0 * number1 / number2; Console.WriteLine($"{number1} / {number2} = {output:f2}"); }
            }
            else if (operation == "%")
            {
                
                if (number2 == 0) { Console.WriteLine($"Cannot divide {number1} by zero"); }
                else { output = number1 % number2; Console.WriteLine($"{number1} % {number2} = {output}"); }
            }
        }
    }
}
