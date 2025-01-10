using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_OOP04.Abstraction
{
    internal class Square : Shape
    {
        public override double Perimeter
        {
            get
            {
                return Dim02 * 4;
            }
        }

        public override double GetArea()
        {
            return Dim01 * Dim01;
        }
    }
}
