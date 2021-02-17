﻿using System;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time();
            t1.Hour = 11;
            t1.Minute = 18;
            t1.Second = 3.14159;
            Console.WriteLine(t1);

            Time t2 = new Time(11, 8, 3.14159);
            Console.WriteLine(t2);
        }
    }

    public class Time
    {
        public int Hour, Minute;
        public double Second;
    
        public Time()
        {
            this.Hour = 0;
            this.Minute = 0;
            this.Second = 0.0;
        }

        public Time(int hour, int minute, double second)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }
    }

}
