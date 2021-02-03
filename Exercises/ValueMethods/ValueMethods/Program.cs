using System;

namespace ValueMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool IsDivisible(int n, int m)
        {
            return n % m == 0;
           
        }
    }
}
