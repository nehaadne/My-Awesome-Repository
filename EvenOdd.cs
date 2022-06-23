using System;

namespace MyFirstProject
{
    class EvenOdd
    {
        public static void Main1()
        {
            int num;
            Console.WriteLine("Enter a no.");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }
    }
}
