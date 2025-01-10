using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_OOP04.Abstraction
{
    // Abstract Class : Partial Class [Not Fully Implemented Class]
    // Concert Class  : Fully Implemented Class 
    internal abstract class Shape
    {
        public double Dim01 { get; set; }
        public double Dim02 { get; set; }

        // Abstract Method : Like Virutal Method Without Implementation 
        public abstract double GetArea();

        // Make This Method Abstract


        // Abstract Property : Like Virutal Property Without Implementation 
        public abstract double Perimeter { get; }

        public void Print()
        {
            Console.WriteLine("I am Shape");
        }
        
       
    }
}
