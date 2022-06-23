using System;

namespace MyFirstProject
{
    class FirstDividibleSnd
    {
        public static void Main1()
        {
            int num1, num2;
            Console.WriteLine("Enter two numbers");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            if (num1%num2 == 0)
            {
                Console.WriteLine("1st number is divisible by 2nd");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
