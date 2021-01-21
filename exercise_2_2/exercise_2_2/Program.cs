using System;

namespace exercise_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = "Wednesday", month = "January";
            int date = 20, year = 2021;

            //Console.WriteLine(day);
            //Console.WriteLine(month);
            //Console.WriteLine(date);
            //Console.WriteLine(year);

            Console.WriteLine($"American format:");
            Console.WriteLine($"{day}, {month} {date}, {year}");
            Console.WriteLine($"European format:");
            Console.WriteLine($"{day} {date} {month}, {year}");


        }
    }
}
