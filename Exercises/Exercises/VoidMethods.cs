using System;

namespace Exercises
{
    class VoidMethods
    {
        static void Main(string[] args)
        {
            Zool(11, "Mimi", "Darbytown Rd");
        }

        public static void Zool(int num, string pet, string street)
        {
            Console.WriteLine(num);
            Console.WriteLine(pet);
            Console.WriteLine(street);
        }
    }
}
