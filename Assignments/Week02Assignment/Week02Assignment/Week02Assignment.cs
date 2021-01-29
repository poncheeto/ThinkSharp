
// CSC205 Week 02 Assignment


using System;

namespace Week02Assignment
{
    class Week02Assignment
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////// 1 ////////////////////////////////////////////////////

            const int secondsInDay = 86400;
            int hour = 18, minute = 39, second = 36;

            // Calculate and print number of seconds since midnight
            int secondsSinceMidnight = ((hour * 60) + minute) * 60 + second;
            Console.WriteLine($"Seconds since midnight: {secondsSinceMidnight}");

            // Calculate and print seconds remaining in day
            int secondsRemaining = secondsInDay - secondsSinceMidnight;
            Console.WriteLine($"Seconds Remaining in day: {secondsRemaining}");

            // Calculate and print percentage of the day passed
            int percentage = (secondsSinceMidnight * 100 / secondsInDay);
            Console.WriteLine($"Percentage of day passed: {percentage}%");

            hour = 18;
            minute = 59;
            second = 45;
            Console.WriteLine($"Current time: {hour}:{minute}:{second}");

            /////////////////////////////////////////// 2 ////////////////////////////////////////////////////

            ushort a = 52130;
            sbyte b = -115;
            uint c = 4825932;
            byte d = 97;
            short e = -10000;
            ushort f = 20000;
            byte g = 224;
            uint h = 970700000;
            byte i = 112;
            sbyte j = -44;
            int k = -1000000;
            ushort l = 1990;
            ulong m = 123456789123456789;

            /////////////////////////////////////////// 3 ////////////////////////////////////////////////////

            // Get user input in 'abcd' format
            Console.Write("Enter a four-digit number: ");
            string str = Console.ReadLine();
            int num = Convert.ToInt32(str);

            // Obtain individual digits
            int a = num % 10;
            int b = (num / 10) % 10;
            int c = (num / 100) % 10;
            int d = (num / 1000) % 10;

            // Calculate and print sum of all digits
            int sum = a + b + c + d;
            Console.WriteLine($"Sum of all digits: {sum}");

            // Print to console number in reverse order
            Console.WriteLine($"Reverse order: {a}{b}{c}{d}");

            // Put last digit in first position
            Console.WriteLine($"Last digit first: {a}{d}{c}{b}");

            // Exchanges second and third digits
            Console.WriteLine($"Second/third digit exchange: {d}{b}{c}{a}");

        }
    }
}
