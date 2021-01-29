using System;

namespace ConditionalsRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Countdown(10);
        }

        public static void Countdown(int n)
        {
            if (n == 0)
            {
                Console.WriteLine("Blastoff!");
            } else
            {
                Console.WriteLine(n);
                Countdown(n - 1);
            }
        }
    }
}
