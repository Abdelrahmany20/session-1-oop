using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;

namespace session_1_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Exceptions Handle

            // Exceptions
            // 1. System Exceptions
            //// 1.1 Format Exception
            //// 1.2 Index Out Of Range Exception
            //// 1.3 Null Reference Exception
            //// 1.4 Invalid Operation Exception
            //1.5 Arithmetic Exception
            //1.5.1 Divided By Zero Exception
            //1.5.2 Overflow Exception
            // 2. Application Exception







            //public static void DoSomeCode()

            //int X, Y, Z;
            //X = int. Parse(Console.ReadLine());// FormatException
            //Y = int. Parse(Console.ReadLine());

            //Z = X / Y;// DivideByZeroException

            //int[] Numbers = { 1, 2, 3 };

            //Numbers[10] = 100;// IndexOutOfRangeException
            //}












            //try
            //{
            //int X, Y, Z;
            //bool Flag;
            ////X= int.Parse(Console. ReadLine());// FormatException
            //do

            //{
            //Flag = int.TryParse(Console.ReadLine(), out X);
            //} while (!Flag) ;
            //Y = int.Parse(Console.ReadLine());

            //Z = X / Y;// DivideByZeroException


            //if (Numbers?.Length > 10)
            //{
            ////int[] Numbers = { 1, 2, 3 };

            //}

            //Numbers[10] = 100;// IndexOutOfRangeException
            //}


            //try
            //{

            //    DoSomeProtectiveCode();
            //}
            //catch
            //{
            //    (Exception ex)
            //}
            //Console.WriteLine(ex.Message);




            //            try
            //            {
            //                DoSomeProtectiveCode();
            //                throw new Exception();
            //            }}
            //            catch { (Exception ex)

            //Console.WriteLine(ex.Message);
            //    }
            //finally
            //    {  
            //Console.WriteLine("finally    ");
            //// CLose - Free - Delete - Dealocate Unmanged Recources
            //// Open File
            //// Open Connection Database
            //}}
            #endregion


            #region Asscess Modifiers

            // private --> inside class only
            // internal --> inside class scope and other classes inside same project
            // internal --> inside class scope and other classes inside other project (Import)


            //public TypeA()
            //{
            //TypeB typeB = new TypeB();
            //}
            //prIvate int X;
            //internal int Y;
            //public int Z;


            //            internal interface IType

            //What You Can Write Inside The Interface?
            //1. Signature For Property => C# 7.0
            //2. Signature For Method => C# 7.0
            //3. Default Implemented Method => C# 8.0 Feature .Net Core 3.1 [2019]
            #endregion

            #region ENUM



            //  enum Gender
            //  {
            //Male , Female
            // }
            //enum Days
            //  {
            //Saturday,
            //Sunday,
            //Monday,
            //Tuesdayl,
            //Wednesday,
            //Thursday,
            //Friday
            //   }

            //    enum Gender : byte
            //{
            //    Male, Female
            //}
            //enum Grades
            //{
            //    A, B, C, D, E, F
            //}

            //    enum Roles
            //{
            //    Admin = 10, Viewer = 20, Editor = 30
            //}




            #region Ex01

            //string Day = "Hamada";
            //Days Day = Days. Friday;
            //   Grades grade = Grades.A;
            //    if (grade == Grades.A)
            //{
            //        Console.WriteLine(":)");
            // }
            //      else
            // {
            //           Console.WriteLine(":(");
            //           }

            #endregion

            #region Ex02

            //Grades grade = (Grades)2;

            //Console.WriteLine(grade);


            //Console.WriteLine(grade); // C
            //Grades grade = (Grades)10;// Excplicit Casting

            //Console.WriteLine(grade); // }0

            #endregion


            #region Ex03
            //Grades grade = (Grades) Enum. Parse(typeof(Grades), Console. ReadLine());
            //EnumITryParse(typeof(Grades), Console. ReadLine(), out object Result);
            //Grades grade = (Grades) Result;
            //Console. WriteLine (Result);
            #endregion


            #region Ex04
            //string gender = "male";

            //Enum.TryParse(typeof(Gender), gender, out object Result);

            //Console.WriteLine(Result);

            //Enum.TryParse(gender, true, out Gender Result);
            #endregion

            #endregion

            #region permissions


            //class Employee
            //{
            //public string Name;
            //public int Age;
            //public decimal Salary;
            //public Gender Gender; // Male - Female / 0 - 1
            //public Permissions Permissions;
            //}




            //1 => Delete
            //2=> Execute
            //3=> Delete, Execute
            //4=> Read
            //5=> Delete, Read
            //6=> Execute, Read
            //8=> Write
            //7=> Execute, Read,Delete
            //9=> Delete, Write
            //10 => Execute,Write
            //11 => Delete, Execute, Write
            //12 => Read, Write
            //13 => Delete, Read, Write
            //14 => Execute, Read, Write
            //15 => Delete, Execute, Read,Write




            //[Flags]
            //enum Permissions : byte
            //{
            //Delete = 1, Execute = 2, Read = 4, Write = 8
            //}




            //Employee employee = new Employee();
            //employee.Name = "Ali";
            //employee.Age = 20;
            //employee.Permissions = (Permissions)3;

            //Console.WriteLine(employee.Permissions);// Delete, Execute


            // XOR
            //employee.Permissions = employee.Permissions ^ Permissions.Read;

            //Console.WriteLine(employee.Permissions);// Delete, Execute ,Read

            //employee.Permissions = employee.Permissions ^ Permissions.Read;

            //Console.WriteLine(employee.Permissions);// Delete, Execute

            // &


            //if ((employee.Permissions & Permissions.Read) == Permissions.Read)
            //{
            //Console.WriteLine("Read is exist");
            //}
            //else
            //{
            //employee.Permissions = employee.Permissions ^ Permissions.Read;
            //}



            //OR    


            //employee.Permissions = employee.Permissions | Permissions.Read;


            //Console.WriteLine(employee.Permissions);


            #endregion

            #region Struct


            /// What You Can Write Inside The Struct Or Class
            ///1. Attributes[Fields] => Member Variable

            /////int x;
            ///int y;


            ///2. Functions[Constructor, Getter Setter, Method]


            //Constructor Special Function
            //1.Name Constructor Same Name Class or Struct
            //2.no return



            //public Point(int _x, int _y)
            //X= _x;
            //Y= _y;


            ///3. Properties[Full Property, Automatic Property, Indexer]
            ///4. Events

            ///Access Modifier Allowed Inside Struct?
            ///1. Private[Default]
            ///2. Internal
            ///3. Public







            //Console.WriteLine(P01.X);//invalid
            //P01.X=10;
            //P01.Y = 20;
            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            //P01 = new Point(2);

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);


            //Point p01
            //Console.WriteLime(P01); //AlexGroupDemoSession0100P.Point
            //Console.WriteLine(P01.ToString()): //AlexGroupDemoSession0100P.Point



            //int X = 10;
            //Console.WriteLine(X);
            //Console.WriteLine(X.ToString());
            #endregion
        }
    }
}
