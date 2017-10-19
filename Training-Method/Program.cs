using System;
using System.Collections.Generic;

namespace Training_Method
{
    internal class Program
    {
        public static void jumlah(int var1, ref int var2)
        {
            var1 = var1 + 5;
            var2 = var2 + 5;
        }
        
        public static void Main(string[] args)
        {
            int var1 = 5;
            int var2 = 6;
            jumlah(var1, ref var2);
            Console.WriteLine("Nilai Var 1  = {0}",var1);
            Console.WriteLine("Nilai Var 2  = {0}",var2);
        }
    }
}