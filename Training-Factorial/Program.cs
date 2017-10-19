using System;
using System.Collections.Generic;

namespace Training_Factorial
{
    internal class Program
    {
        public static int Factorial(int n)
        {
            if (n > 1)
            {
                return n;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        public static void Main(string[] args)
        {
            int fauzi =Factorial(2);
            Console.WriteLine(fauzi);
        }
    }
}