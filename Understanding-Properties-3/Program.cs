using System;
using System.Collections.Generic;

namespace Understanding_Properties_3
{
    abstract class shape
    {
        public abstract double Area { get; set; }
    }

    class square : shape
    {
        public double side;

        public square(double s) //construtor
        {
            side = s;
        }

        public override Double Area
        {
            get { return side * side; }
            set { side = Math.Sqrt(value); }
        }
    }

    class  cube : shape
    {
        public double side;

        public cube(double s)
        {
            side = s;
        }

        public override double Area
        {
            get { return 6 * side * side; }
            set { side = Math.Sqrt(value / 6); }
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the side");
            double side = double.Parse(Console.ReadLine());
            Console.ReadKey();
            
            square s = new square(side);
            cube c = new cube(side);
            
            //display result 
            Console.WriteLine("Area of the Squere = {0:F2}", s.Area);
            Console.WriteLine("Area of the Cube = {0:F2}", c.Area);
            Console.WriteLine();
            
            Console.Write("Enter the area");
            double area = double.Parse(Console.ReadLine());
            Console.ReadKey();

            s.Area = area;
            c.Area = area;
            
            //display result
            Console.WriteLine("Side of the squere = {0:F2}", s.side);
            Console.WriteLine("Side of the cube = {0:F2}", c.side);
        }
    }
}