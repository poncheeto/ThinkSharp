using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random random = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    double x = random.NextDouble();
            //    Console.WriteLine(x);
            //}

            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine(CloneArray(array));
        }

        static public int[] CloneArray(int[] array)
        {
            int size = array.Length;
            int[] newArray = new int[size];

            int i = 0;
            while (i < size)
            {
                newArray[i] = array[i];
                i++;
            }
            return newArray;
        }

    }
}
