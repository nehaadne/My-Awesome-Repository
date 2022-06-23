using System;

namespace MyFirstProject
{
    class Maxno
    {
        public static void Main1()
        {
            int num1, num2;
            int maxnum;
            Console.WriteLine("Enter 1st no");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd no");
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                maxnum = num1;
            }
            else
            {
                maxnum = num2;
            }
            Console.WriteLine("Maximum no is " + maxnum);


        }
    }
}
