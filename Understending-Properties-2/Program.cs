using System;
using System.Collections.Generic;

namespace Understending_Properties_2
{
    public class Employee
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    
    // Pewarisan
    public class Manager : Employee
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value + " ,Manager"; }
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Manager n1 = new Manager();
            n1.Name = "Fauzi";
            ((Employee) n1).Name = "Fitriani";
            
            Console.WriteLine("Name in the derived class is {0}" , n1.Name);
            Console.WriteLine("Name in the BASE class is {0}" , ((Employee)n1).Name);
        }
    }
}