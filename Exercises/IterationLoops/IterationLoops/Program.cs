using System;

namespace IterationLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Countdown(10);
            Loop(10);
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

        public static void Loop(int n)
        {
            int i = n;
            while (i > 0)
            {
                Console.WriteLine((i));
                if (i % 2 == 0)
                {
                    i = i / 2;
                }
                else
                {
                    i = i + 1;
                }
            }
        }

    }
}
