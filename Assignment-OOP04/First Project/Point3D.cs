using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP04.First_Project
{
    internal class Point3D : IComparable, ICloneable
    {
        #region Q1 , Q2 , Q3 , Q4 , Q5

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D() : this(0, 0, 0) { }
        public Point3D(int x, int y) : this(x, y, 0) { }

        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void Display()
        {
            Console.WriteLine($"Point3D Coordinates: ({X}, {Y}, {Z})");
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        #endregion


        

        #region Q6



        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            if (obj is Point3D other)
            {
                int xComparison = X.CompareTo(other.X);
                if (xComparison != 0) return xComparison;

                int yComparison = Y.CompareTo(other.Y);
                if (yComparison != 0) return yComparison;

                return Z.CompareTo(other.Z);
            }

            throw new ArgumentException("Object is not a Point3D");
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }

        #endregion


    }
}
