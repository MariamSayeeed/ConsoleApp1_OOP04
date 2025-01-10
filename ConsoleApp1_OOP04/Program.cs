using ConsoleApp1_OOP04.Abstraction;
using ConsoleApp1_OOP04.Mapping;
using ConsoleApp1_OOP04.Operator_Overloding;
using ConsoleApp1_OOP04.Static;

namespace ConsoleApp1_OOP04
{
    internal class Program
    {
        static void Main()
        {
            #region Abstraction

            //// 4. Abstraction : 
            //// abstract : C# Key Word [Class - methods - Properties]
            //// abstract class
            //// abstract method
            //// abstract proper

            //// 2D Shape 

            //// Shape shape = new Shape();
            //// NOTE : Can't Create Object From Abstract Class

            ////Shape.GetArea();

            //Rectanglec rectanglec = new Rectanglec()
            //{
            //    Dim01 = 12,
            //    Dim02 = 3,
            //};

            ////rectanglec.Perimeter = 10; // Not Valide
            //Console.WriteLine(rectanglec.Perimeter); // 30

            //Console.WriteLine(rectanglec.GetArea()); // 36

            //rectanglec.Print(); // I am Shape

            #endregion

            #region Interface Vs Abstract Class

            // Interface Vs Abstract Class
            // .NET 3.1 Core

            #endregion

            #region Operator Overloding ( + Operator)

            // Operator Overloding

            // + - * / % > < = >= <= != == || && !| &! ^ >>

            // + 

            //int X = 3 + 4;
            //string Y = "Hello " + "World";

            //// Complex Number : Real + Imag

            //// 4 + 3 i
            //// 4 + 3 ت 

            //Complex C01 = new Complex() { Real = 3, Imag = 4 };
            //Complex C02 = new Complex() { Real = 4, Imag = 2 };

            //Console.WriteLine(C01); // 3 + 4 i
            //Console.WriteLine(C02); // 4 + 2 i

            //Complex C03 = C01 + C02;

            //Console.WriteLine(C03); // 7 + 6 i


            //Complex C04 = C01 - C02;
            //Console.WriteLine(C04); // -1 + 2 i

            //Complex C05 = C01 - null;
            //Console.WriteLine(C05); // 

            #endregion

            #region  Operator Overloding ( ++ Operator)

            // ++ --
            // Unary Operator

            //int X = 12;

            //X++;

            //Console.WriteLine(X); // 13

            //Console.WriteLine(C01); // 3 + 4 i
            //C01++;

            //Console.WriteLine(C01); // 4 + 4 i

            //Console.WriteLine(C01); // 3 + 4 i
            //C01--;

            //Console.WriteLine(C01); // 2 + 2 i

            #endregion

            #region  Operator Overloding (Comparision  Operator)

            //if (C01 > C02)
            //{
            //    Console.WriteLine("C01 is Greater than C02 ");
            //}
            //else
            //{
            //    Console.WriteLine("C01 is Not Greater than C02 ");

            //}

            // C01 is Not Greater than C02
            // C01 is Greater than C02 ==> 6

            //if (C01 >= C02)
            //{
            //    Console.WriteLine("C01 is Greater than C02 ");
            //}
            //else
            //{
            //    Console.WriteLine("C01 is Not Greater than C02 ");

            //}

            #endregion

            #region User-Defined Casting Operator & Manual Mapping

            //double X = 12;

            //int Y = (int)X;
            // (int) : Casting Operator

            //Complex C01 = new Complex() { Real = 3, Imag = 4 };

            //string S = (string)C01;
            //// (String) : Convert Complex Number To String 

            //// Operator Overlodding
            //// User-Defined Casting Operator 

            //Console.WriteLine(S); // 3 + 4 i

            //int X = /* (int) */ C01;

            //Console.WriteLine(C01); // 400

            //int X =  (int)  new Complex() { Real =4 , Imag = 7 };

            // Mapping : Convert From Datatype To Datatype

            // Code First 
            // DB First

            // User  [Id , Name , Email , Password , UserName , PhoneNumber , CardNumber , ExpireDate ] 

            // UserViewModel 
            // UserDto
            // [Name , Email , PhoneNumber ]

            //User user = new User(); // From DB 

            //// Mannual Mapping
            //UserDto userDto = new UserDto()
            //{
            //    Email = user.Email,
            //    Name = user.Name,
            //    PhoneNumber = user.PhoneNumber,
            //};

            // Casting Operator

            // Automapper : Mapping Automatic

            #endregion

            #region Static [Class, Method, Consteuctor, Property, Attributes]

            // Static : C# Keyword [Class, Method, Consteuctor, Property, Attributes]
            // Static Class
            // Static Mehtod
            // Static Property
            // Static Constructor
            // Static Attribute

            //Utilities U01 = new Utilities();
            //Utilities U02 = new Utilities();
            //Utilities U03 = new Utilities();

            //Console.WriteLine(U01.CmToInch(254)); // 100
            //Console.WriteLine(U02.CmToInch(254)); // 100
            //Console.WriteLine(U03.CmToInch(254)); // 100


            //Console.WriteLine(Utilities.CmToInch(254)); // 100
            //Console.WriteLine(Utilities.CmToInch(254)); // 100
            //Console.WriteLine(Utilities.CmToInch(254)); // 100

            //Console.WriteLine(U01.PI); // 3.14
            //Console.WriteLine(U02.PI); // 3.14
            //Console.WriteLine(U03.PI); // 3.14


            //Console.WriteLine((Utilities.PI)); // 3.14
            //Console.WriteLine((Utilities.PI)); // 3.14
            //Console.WriteLine((Utilities.PI)); // 3.14

            //Utilities U1 = new Utilities();

            #endregion

            #region Sealed (Class, Method, Property)

            //Sealed : C# Keyword [Class - Method - Property]

            #endregion

            #region Partial Classes

            // Partial

            //Employee employee = new Employee();
            //employee.

            #endregion

        }
    }
}
