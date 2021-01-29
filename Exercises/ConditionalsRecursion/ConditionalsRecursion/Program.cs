using System;

namespace ConditionalsRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Countdown(10);
            // NLines(12);
            NinetyNineBottles(99);
        }

        //public static void Countdown(int n)
        //{
        //    if (n == 0)
        //    {
        //        Console.WriteLine("Blastoff!");
        //    } else
        //    {
        //        Console.WriteLine(n);
        //        Countdown(n - 1);
        //    }
        //}

        //public static void NLines(int n)
        //{
        //    if (n > 0) // account for negative numbers
        //    {
        //        Console.WriteLine();
        //        NLines(n - 1);
        //    }
        //}

        static void NinetyNineBottles(int n)
        {
            if (n == 0)
            {
                Console.WriteLine("No bottles of beer on the wall, no bottles of beer, ya’ can’t take one down, ya’can’t pass it around, ’cause there are no more bottles of beer on the wall!");
            } else
            {
                Console.WriteLine($" {n} bottles of beer on the wall, {n} bottles of beer, ya’ take one down, ya’ pass it around, {n - 1} bottles of beer on the wall.");
                NinetyNineBottles(n - 1);
            }
        }
    }
}
