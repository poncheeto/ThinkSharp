using System;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Time
    {
        public int Hour, Minute;
        public double Second;
    }

    public Time()
    {
        this.Hour = 0;
        this.Minute = 0;
        this.Second = 0.0;
    }
}
