using System;
using System.Collections.Generic;

namespace Training_Class
{
    internal class Program
    {
        private double length;
        private double width;

        public void Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public double GetArea()
        {
            return length * width;
        }
        public static void Main(string[] args)
        {
            
        }
    }
}