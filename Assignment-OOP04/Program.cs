using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using Assignment_OOP04.First_Project;
using Assignment_OOP04.Second_Project;
using Assignment_OOP04.Third_Project;

namespace Assignment_OOP04
{
    internal class Program
    {

        #region First_Project Q3
        private static int GetCoordinate(string pointName, string coordinateName)
        {
            int value;
            while (true)
            {
                Console.Write($"Enter {coordinateName} for {pointName}: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out value))
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            return value;
        } 
        #endregion


        static void Main()
        {
            #region First Project

            #region Q1

            // 1. Define 3D Point Class and the basic Constructors (use chaining in constructors).

            //Point3D P1 = new Point3D();    // default values
            //P1.Display();

            //Point3D P2 = new Point3D(5, 10);
            //P2.Display();


            #endregion

            #region Q2
            // 2. Override the ToString Function to produce this output:

            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(P.ToString());

            #endregion

            #region Q3

            // 3. Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).

            //Console.WriteLine("Enter coordinates for Point P1:");
            //Point3D P1 = new Point3D(
            //    GetCoordinate("P1", "X1"),
            //    GetCoordinate("P1", "Y1"),
            //    GetCoordinate("P1", "Z1")
            //);

            //Console.WriteLine("\nEnter coordinates for Point P2:");
            //Point3D P2 = new Point3D(
            //    GetCoordinate("P2", "X2"),
            //    GetCoordinate("P2", "Y2"),
            //    GetCoordinate("P2", "Z2")
            //);

            //Console.WriteLine("\nCoordinates of the points:");
            //Console.WriteLine($"P1: {P1}");
            //Console.WriteLine($"P2: {P2}");



            #endregion

            #region Q4

            // 4. Try to use == If(P1 == P2)   Does it work properly?  

            //Point3D P1 = new Point3D(1, 2, 3);
            //Point3D P2 = new Point3D(1, 2, 3); // P1 and P2 are equal.


            //if (P1 == P2)
            //{
            //    Console.WriteLine("P1 and P2 are equal.");
            //}
            //else
            //{
            //    Console.WriteLine("P1 and P2 are not equal.");
            //}

            //Point3D P2 = new Point3D(4, 5, 6); // P1 and P2 are not equal.

            //if (P1 == P2)
            //{
            //    Console.WriteLine("P1 and P2 are equal.");
            //}
            //else
            //{
            //    Console.WriteLine("P1 and P2 are not equal.");
            //}

            #endregion

            #region Q5

            // 5. Define an array of points and sort this array based on X & Y coordinates.

            //Point3D[] points = new Point3D[]
            //{
            //    new Point3D(1, 2, 3),
            //    new Point3D(4, 8, 2),
            //    new Point3D(3, 6, 4),
            //    new Point3D(2, 9, 1),
            //    new Point3D(5, 7, 8)
            //};

            //Console.WriteLine("Original Array:");
            //foreach (var point in points)
            //{
            //    point.Display();
            //}

            //Array.Sort(points, (p1, p2) =>
            //{
            //    int xComparison = p1.X.CompareTo(p2.X);
            //    return xComparison != 0 ? xComparison : p1.Y.CompareTo(p2.Y);
            //});

            //Console.WriteLine("Sorted Array :");
            //foreach (var point in points)
            //{
            //    point.Display();
            //}

            //Original Array:
            //(1, 2, 3)
            //(4, 8, 2)
            //(3, 6, 4)
            //(2, 9, 1)
            //(5, 7, 8)
            //Sorted Array :
            //(1, 2, 3)
            //(2, 9, 1)
            //(3, 6, 4)
            //(4, 8, 2)
            //(5, 7, 8)

            #endregion

            #region Q6

            // 6. Implement ICloneable interface to be able to clone the object.
            //To implement more than one interface.
            //class Point3D : IComparable, ICloneable

            //Point3D point1 = new Point3D(1, 3, 5);

            //Point3D point2 = (Point3D)point1.Clone();

            //Console.WriteLine("Original Point:");
            //point1.Display();

            //Console.WriteLine("Cloned Point:");
            //point2.Display();

            //point2.X = 7;
            //point2.Y = 8;
            //point2.Z = 9;

            //Console.WriteLine("After modifying:");
            //Console.WriteLine("Original Point:");
            //point1.Display();
            //Console.WriteLine("Cloned Point:");
            //point2.Display();

            //Point3D[] points = new Point3D[]
            //{
            //new Point3D(2, 7, 9),
            //new Point3D(3, 4, 8),
            //new Point3D(1, 6, 1)
            //};

            //Console.WriteLine("Unsorted Points:");
            //foreach (var point in points)
            //{
            //    point.Display();
            //}

            //Array.Sort(points);

            //Console.WriteLine("Sorted Points:");
            //foreach (var point in points)
            //{
            //    point.Display();
            //}


            #endregion

            #endregion

            #region Second Project:

            //Define Class Maths that has four methods: Add, Subtract, Multiply, and Divide, each of them takes two parameters.Call each method in Main().
            //Modify the program so that you do not have to create an instance of class to call the four methods.

            //double Number1 = 10;
            //double Number2 = 5;
            //double Number3 = 0;

            //double Sum = Maths.Add(Number1, Number2);
            //double Sub = Maths.Subtract(Number1, Number2);
            //double Mul = Maths.Multiply(Number1, Number2);
            //double Div = Maths.Divide(Number1, Number2);

            //Console.WriteLine($"Add       : {Number1} + {Number2} = {Sum} ");
            //Console.WriteLine($"Subtract  : {Number1} - {Number2} = {Sub} ");
            //Console.WriteLine($"Multiply  : {Number1} * {Number2} = {Mul} ");
            //Console.WriteLine($"Divide    : {Number1} / {Number2} = {Div} ");
            //Console.WriteLine(Maths.Divide(Number1, Number3));


            #endregion

            #region Third Project:

            //Duration D1 = new Duration(1, 30, 5);
            //Console.WriteLine(D1.ToString()); 

            //Duration D2 = new Duration(3600);
            //Console.WriteLine(D2.ToString());  

            //Duration D3 = new Duration(7800);
            //Console.WriteLine(D3.ToString());  

            //Duration D4 = new Duration(666);
            //Console.WriteLine(D4.ToString());  

            #endregion
        }
    }
}
