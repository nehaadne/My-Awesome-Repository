using System;

namespace Demo
{

    class Calc
    {


        public static void Main2()
        {

            Console.WriteLine("start Main method");
            sum();
            subtract();
            division();
            multiplication();


        }
        public static void sum()
        {
            Console.WriteLine(3 + 6);
        }
        public static void subtract()
        {
            Console.WriteLine(3 - 6);
        }
        public static void division()
        {
            Console.WriteLine(3 / 6);
        }
        public static void multiplication()
        {
            Console.WriteLine(3 * 6);
        }

    }
}

