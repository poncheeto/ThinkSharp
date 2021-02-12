using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("Hello"));
        }

        static string ReverseString(string str)
        {
            string reverse = "";
            int length = str.Length;
            int i = length - 1;

            while (i >= 0)
            {
                char letter = str[i];
                reverse += letter;
                i--;
            }
            return reverse;
        }
    }
}
