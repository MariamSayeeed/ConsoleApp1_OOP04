using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_OOP04.Abstraction
{
    // Concert Class : Fully Implemneted Class

    internal class Rectanglec : Shape /*Implement And Inhert From Shape*/
    {
        public override double GetArea()
        {
            return Dim01 * Dim02;
        }
        public override double Perimeter
        {
            get
            {
                return (Dim02 + Dim01) * 2;
            }

        }
    }
}
