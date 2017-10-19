using System;
using System.Collections.Generic;

namespace Understanding_Delegates
{
    public delegate double Delegate_Prod(int a, int b); 
    internal class Program
    {
        static double fn_Prodvalues(int val1, int val2)
        {
            return val1 * val2;
        }
        
        public static void Main(string[] args)
        {
            Delegate_Prod delObj = new Delegate_Prod(fn_Prodvalues);
            Console.WriteLine("Please enter Values");
            int v1 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            
            Console.WriteLine("Please enter Values");
            int v2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();

            double res = delObj(v1, v2);
            Console.WriteLine("Result " + res);
            Console.ReadLine();
        }
    }
}