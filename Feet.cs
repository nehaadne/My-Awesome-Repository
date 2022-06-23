using System;

namespace MyFirstProject
{
    internal class Feet
    {
        public static void Main1()
        {
            double feet, meter;
            Console.WriteLine("Enter Feet");
            feet = Convert.ToInt32(Console.ReadLine());
            meter = feet / 3.281;
            Console.WriteLine("Feet in meter " + meter);
        }
    }
}
