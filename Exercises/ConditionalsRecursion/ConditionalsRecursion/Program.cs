using System;

namespace ConditionalsRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Countdown(10);
            // NLines(12);
            // NinetyNineBottles(99);
            CheckFermat(1, 2, 3, 4);
            CheckFermat(3, 4, 5, 2);
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

        // public static void NinetyNineBottles(int n)
        //{
        //    if (n == 0)
        //    {
        //        Console.WriteLine("No bottles of beer on the wall, no bottles of beer, ya’ can’t take one down, ya’can’t pass it around, ’cause there are no more bottles of beer on the wall!");
        //    } else
        //    {
        //        Console.WriteLine($" {n} bottles of beer on the wall, {n} bottles of beer, ya’ take one down, ya’ pass it around, {n - 1} bottles of beer on the wall.");
        //        NinetyNineBottles(n - 1);
        //    }
        //}

        public static void CheckFermat(int a, int b, int c, int n)
        {

            bool fermat = Math.Pow(a, n) + Math.Pow(b, n) == Math.Pow(c, n);

            if (n > 2 && fermat) {
                Console.WriteLine("Holy smokes, Fermat was wrong!");
            } else if (n == 2 && fermat)
            {
                Console.WriteLine("That works!");
            } else
            {
                Console.WriteLine("No, that doesn't work.");
            }
            Console.WriteLine(fermat);
        }
    }
}
