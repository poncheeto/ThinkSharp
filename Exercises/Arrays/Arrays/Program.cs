using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random.NextDouble();
                Console.WriteLine(x);
            }
        }
    }
}
