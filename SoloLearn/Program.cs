using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SoloLearn
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] a = {5, 6, 10};
            int q = a.Max();
            Console.WriteLine(q);
            int s = a.Sum();
            Console.WriteLine(a);
            int n = a.Max() + a.Sum() % 10;
            
            Console.Write(n);
            
            Console.WriteLine("=======================================");
            Console.WriteLine("=======================================");
            Console.WriteLine("=======================================");

//            try
//            {
//
//                int a;
//                int b = 15;
//                a = (int) b + 20;
//                Console.Write(b);
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e);
//                
//            } 
        }
    }
}