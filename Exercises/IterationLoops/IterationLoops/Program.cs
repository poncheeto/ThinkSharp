using System;

namespace IterationLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Countdown(10);
        }

        // Iterative Countdown

        public static void Countdown(int n)
        {
            while (n > 0)
            {
                Console.WriteLine(n);
                n -= 1;
            }
            Console.WriteLine("Blastoff!");
        }
    }
}
