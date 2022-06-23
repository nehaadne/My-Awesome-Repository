using System;

namespace MyFirstProject
{
    class AvgoffFourno
    {
        public static void Main1()
        {
            int num1, num2, num3, num4;
            Console.WriteLine("Enter 1st number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd number");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 4th number");
            num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Avg Of No " + (num1 + num2 + num3 + num4) / 4);


        }
    }
}
