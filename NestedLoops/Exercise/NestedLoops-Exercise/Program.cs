﻿using System;
using System.Data;

namespace NestedLoops_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int current = 1;
            bool isFound = false;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (current > n)
                    {
                        isFound = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                if (isFound) { break; }
                Console.WriteLine();
                
            }

        }
    }
}
