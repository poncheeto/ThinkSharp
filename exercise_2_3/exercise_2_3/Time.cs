using System;

namespace exercise_2_3
{
    class Time
    {
        static void Main(string[] args)
        {
            int hour = 20, minute = 22, second = 36;

            int sum_time = ((hour * 60) + minute) * 60;
            Console.WriteLine(sum_time);
            int seconds_since_midnight = 0;
        }
    }
}
