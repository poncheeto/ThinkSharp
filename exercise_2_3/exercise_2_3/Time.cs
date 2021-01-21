using System;

namespace exercise_2_3
{
    class Time
    {
        static void Main(string[] args)
        {
            int SECONDS_IN_DAY = 86400;
            int hour = 20, minute = 22, second = 36;

            int seconds_since_midnight = ((hour * 60) + minute) * 60 + second;
            Console.WriteLine($"Seconds since midnight: {seconds_since_midnight}");

            int seconds_remaining = SECONDS_IN_DAY - seconds_since_midnight;
            Console.WriteLine($"Seconds Remaining in day: {seconds_remaining}");

            int percentage = (seconds_since_midnight * 100 / SECONDS_IN_DAY);
            Console.WriteLine($"Percentage of day passed: {percentage}");

            hour = 20;
            minute = 40;
            second = 45;
            Console.WriteLine($"Current time: {hour}:{minute}:{second}");

        }
    }
}
