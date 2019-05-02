using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   //ques 1
            Console.Write("Enter any number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("The Opposite number will be: {0}", Opposite(num1));
            Console.ReadLine();

            //ques 2
            Console.Write("Enter the distance from your home in miles: ");
            double dist = double.Parse(Console.ReadLine());

            Console.WriteLine("The distance in kilometers is: {0}", distance(dist));
            Console.ReadLine();

            //ques 3(a)
            Console.Write("enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("The circumference of the circle is: {0}", Circum(radius));
            Console.Write("The area of the circle is: {0}", Area(radius));
            Console.ReadLine();

        }

        //method 1 for ques 1
        static int Opposite(int number)
        { return -number; }

        //method 2 for ques 2
        static double distance(double miles)
        { return miles * 0.62137; }

        //method 3 for ques 3(a)
        static double Circum(double radii)
        {
            return 2 * 3.1416 * radii;
            // 2* Math.PI * radii
        }

        static double Area(double radii )
        { return Math.PI * (radii * radii); }

    }
}
