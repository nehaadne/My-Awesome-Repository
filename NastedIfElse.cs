using System;

namespace MyFirstProject
{
     class NastedIfElse
    {
        public static void Main1()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter greater number");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
                    Console.WriteLine("num1 is greater");
                else if (num2 > num1 && num2> num3)
                    Console.WriteLine("num2 is greater");
                else
                    Console.WriteLine("num3 is greater");



        }
    }
}
