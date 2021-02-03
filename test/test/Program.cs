/*
 * Lecture slides / textbook code
 * 3.5 Adding New Methods
 * 3.6 Classes and methods
 */
using System;

namespace CSC205
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Enter a floating number: ");
            x = Convert.ToDouble(Console.ReadLine());
            WriteLog(x);
            Console.WriteLine($"The log of {x} is: " + WriteLog(x));
        }

        public static double WriteLog(double x)
        {
            if (x <= 0.0)
            {
                Console.WriteLine("Positive number only, please.");
                return -1;
            }

            double result = Math.Log(x);
            return result;
            // Console.WriteLine("The log of x is : " + result);
        }
    }
}
