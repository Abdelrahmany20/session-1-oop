namespace session_1_oop
{


    internal enum WeekDays
    {
        monday, tuesday, wednesday, thursday, friday, saterday, sunday
    }

    enum Season
    {
        Spring, Summer, Autumn, Winter
    }


    [Flags]
    enum Permissions
    {
        Read, Write, Delete, Execute




    }


    enum Colors
    {
        Red,
        Green,
        Blue
    }


    public struct point
    {


        public double X;
        public double Y;
    }





    internal class Program
    {






        static void Main(string[] args)
        {
            #region Q01
            //1.	Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
            //Then, write a C# program that prints out all the days of the week using this enum

            //WeekDays[] days =

            //{
            //WeekDays.saterday,
            //WeekDays.sunday,
            //WeekDays.monday,
            //WeekDays.tuesday,
            //WeekDays.wednesday,
            //WeekDays.thursday,
            //WeekDays.friday,




            //};
            //for (int i = 0; i < days.Length; i++)
            //{

            //Console.WriteLine(days[i]);
            //}





            #endregion


            #region Q02
            //2.	Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
            //Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)



            //Season season;
            //bool flag;

            //do
            //{
            //    Console.Write("Enter the season: ");
            //    string input = Console.ReadLine();

            //    flag = Enum.TryParse(typeof(Season), input, true, out object result);

            //    if (flag)
            //    {
            //        season = (Season)result;

            //        if (season == Season.Spring)
            //        {
            //            Console.WriteLine(" Monthes Range : March, April, May");
            //        }
            //        else if (season == Season.Summer)
            //        {
            //            Console.WriteLine("Monthes Range : June, July, August");
            //        }
            //        else if (season == Season.Autumn)
            //        {
            //            Console.WriteLine("Monthes Range : September, October, November");
            //        }
            //        else if (season == Season.Winter)
            //        {
            //            Console.WriteLine("Monthes Range : December, January, February");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Enter Season : Spring or Summer or Autumn or Winter ");
            //    }


            //} while (!flag);






            #endregion


            #region Q03



            //Permissions permission = Permissions.Read | Permissions.Write; 

            //if ((permission & Permissions.Read) == Permissions.Read)
            //{
            //Console.WriteLine("Read is exist");
            //}
            //else
            //{
            //permission = permission ^ Permissions.Read;
            //}

            //if ((permission & Permissions.Write) == Permissions.Write)
            //{
            //Console.WriteLine("Write is exist");
            //}
            //else
            //{
            //permission = permission ^ Permissions.Write;
            //}

            //if ((permission & Permissions.Delete) == Permissions.Delete)
            //{
            //Console.WriteLine("Delete is exist");
            //}
            //else
            //{
            //permission = permission ^ Permissions.Delete;
            //}

            //if ((permission & Permissions.Execute) == Permissions.Execute)
            //{
            //Console.WriteLine("Execute is exist");
            //}
            //else
            //{
            //permission = permission ^ Permissions.Execute;
            //}

            //Console.WriteLine(permission);


            #endregion


            #region Q04




            //string color;
            //bool flag;

            //do
            //{
            //Console.WriteLine("Enter a color :");
            //color = Console.ReadLine();

            //flag = Enum.TryParse(typeof(Colors), color, true, out object result);

            //if (!flag)
            //{
            //Console.WriteLine("the input  is not primary color ,Enter again : ");
            //}
            //}
            //while (!flag);

            //Console.WriteLine($"{color} is a primary color.");




            #endregion


            #region Q05

            //point p1 = new point();
            //point p2= new point();



            //Console.WriteLine("Enter the X 1:");
            //p1.X = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the Y 1:");
            //p1.Y = double.Parse(Console.ReadLine());



            //Console.WriteLine("Enter the X 2:");
            //p2.X = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the Y 2:");
            //p2.Y = double.Parse(Console.ReadLine());


            //double distance =Math.Sqrt(Math.Pow(p2.X-p1.X,2)+Math.Pow(p2.Y-p1.Y,2));

            //Console.WriteLine(distance);

            #endregion







        }
    }
}







