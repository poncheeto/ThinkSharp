using System;

namespace ValueMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(IsDivisible(4, 2));
            // Console.WriteLine(Multadd(1.0, 2.0, 3.0));


            double a = Math.Cos(Math.PI / 4.0);
            double b = 1.0 / 2.0;
            double c = Math.Sin(Math.PI / 4.0);
            Console.WriteLine(Multadd(a, b, c));

            double a1 = 1.0;
            double b1 = Math.Log(10);
            double c1 = Math.Log(20);
            Console.WriteLine(Multadd(a1, b1, c1));
        }

        public static bool IsDivisible(int n, int m)
        {
            return n % m == 0;
        }

        public static double Multadd(double a, double b, double c)
        {
            return a * b + c;
        }

        public static double Yikes(double x)
        {
            double a = x;
            double b = Math.Exp(-x);
            double c = Math.Sqrt(1.0 - b);
            Multadd(a, b, c);
        }
    }
}
