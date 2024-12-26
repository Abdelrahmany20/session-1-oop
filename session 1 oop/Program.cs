using System.ComponentModel;
using System.Drawing;
using System.Reflection;

namespace session_1_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {






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
