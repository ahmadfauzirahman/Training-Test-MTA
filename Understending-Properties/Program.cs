using System;
using System.Collections.Generic;

namespace Understending_Properties
{

    public class Employee
    {
        public static int NumberOfEmployess;
        private static int counter;
        private string name;
        
        //  a read and write intance property     
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        // a read-only static property
        public static int Counter
        {
            get { return counter; }
        }
        
        // A construtor

        public Employee()
        {
            counter = ++counter + NumberOfEmployess;
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Employee.NumberOfEmployess = 107;
            Employee e1 = new Employee();
            e1.Name = "Ahmad Fauzi Rahman";
            
            Console.WriteLine("Employe number : {0}", Employee.Counter);
            Console.WriteLine("Employe name : {0}", e1.Name);
        }
    }
}