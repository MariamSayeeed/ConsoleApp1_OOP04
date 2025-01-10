using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP04.Second_Project
{
    internal class Maths
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Can not divide by 0 !");
                return double.NaN;
            }
            else
            {
                return a / b;
            }
        }
    }
}
