﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc c = new Calc();
            int ans = c.Add(10, 84);
            Console.WriteLine("10 + 84 is {0}.", ans);
            // Wait for user to press the Enter key before shutting down.
            Console.ReadLine();
        }
    }
    // The C# calculator
    class Calc
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
