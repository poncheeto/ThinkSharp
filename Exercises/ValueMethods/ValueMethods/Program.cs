using System;

namespace ValueMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsDivisible(4, 2));
        }

        public static bool IsDivisible(int n, int m)
        {
            return n % m == 0;
        }

        public static double Multadd(double a, double b, double c)
        {
            return a * b + c;
        }
    }
}
