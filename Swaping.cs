using System;

namespace MyFirstProject
{
    class Swaping
    {
        public static void Main1()
        {
            int num1= 7, num2 = 5;
            Console.WriteLine("Swap Values Of Two Variable");
            Console.WriteLine("Value before swap");
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            num1 = num1+num2;
            num2 = num1-num2;
            num1 = num1-num2;
            Console.WriteLine("Value after swap");
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
    }
}
