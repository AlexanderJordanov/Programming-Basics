﻿using System;

namespace USDtoBgn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            Console.WriteLine(usd * 1.79549);
        }
    }
}
