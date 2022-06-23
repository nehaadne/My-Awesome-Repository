using System;

namespace MyFirstProject
{
    class dividingtwono
    {
        public static void Main1()
        {
            int num1, num2;
            Console.WriteLine("Enter 1st no");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd no");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("quotient. " + (num1 / num2));
            Console.WriteLine("remainder. " + (num1 % num2));


        }
    }
}
