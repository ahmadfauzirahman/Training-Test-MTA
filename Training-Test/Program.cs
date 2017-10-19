using System;
using System.Collections.Generic;

namespace Training_Test
{
    internal class Program
    {
        static int i = 5;
        static void Func(int i)
        {
            i = 10;
        }
        public static void Main(string[] args)
        {
            string one = "sololearn";
            string two = one;
            string three = one.Remove(2);
            Console.WriteLine(three);
            string four = two.Substring(4);
            Console.Write(three+four);
            
            Console.WriteLine("========================");
            Test t = new Test();
            Console.Write(t.a);
            Console.WriteLine();
            Console.WriteLine("=====================");
            Console.Write(i);
            
        }


        public class Test
        {
            public int a = 5;

            public Test()
            {
                int a = 3;
                a++;
            }
        }
    }
}