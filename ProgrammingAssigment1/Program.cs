using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// this application will calculate the distance between two points and the angle between those points
    /// </summary>
    class Program
    {
        /// <summary>
        /// this application will calculate the distance between two points and the angle between those points
        /// </summary>
        /// <param name="args">comand-line params</param>
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Please Welcome!!! This application will calculate the distance between two points and the angle between those points");
            Console.WriteLine();

            // Enter first point coordinates
            Console.Write("Please enter X-coordinate for first point: ");
            float point1X = float.Parse(Console.ReadLine());
            Console.Write("Enter Y-coordinate for first point: ");
            float point1Y = float.Parse(Console.ReadLine());
            Console.WriteLine();

            //Enter second point coordinate
            Console.Write("Please enter X-coordinate for second point: ");
            float point2X = float.Parse(Console.ReadLine());
            Console.Write("Enter Y-coordinate for second point: ");
            float point2Y = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Coordinates of point 1: (" + point1X + "," + point1Y + ")");
            Console.WriteLine("Coordinates of point 2: (" + point2X + "," + point2Y + ")");
            Console.WriteLine();

            // Calculate distance between this point, using Pythagoras theorem
            // Calculate two katets, point3 - is a point of square triangle
            float point3X = point2X;
            float point3Y = point1Y;
            double katet1 = point3X - point1X;
            double katet2 = point3Y - point2Y;
            Console.WriteLine("Coordinates of point 3: (" + point3X + "," + point3Y + ")");

            // Calculate hypotenuse - our distance
            double sumOfkatets = Math.Pow(katet1, 2) + Math.Pow(katet2, 2);
            double hypotenuse = Math.Sqrt(sumOfkatets);


            // Print Result
            Console.WriteLine("The distanse between this two points is equal to " + Math.Round(hypotenuse, 3));
            Console.WriteLine();

            // Calculate the angle between two points and print result
            double angle = Math.Atan(katet2 / katet1);
            // Convert to degrees
            angle = angle * 180 / Math.PI;
            //if (angle < 0)
            // angle = 180 + angle;
            Console.WriteLine("The angle is equal to " + Math.Round(angle, 3) + " degrees");
            Console.WriteLine();
        }
    }
}
