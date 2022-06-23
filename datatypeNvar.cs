using System;

namespace MyFirstProject
{
    class datatypeNvar
    {
        public static void Main3()
        {
            //int num1 = 5;
            //int num2 = 4;
            //int num3 = num2;
            //Console.WriteLine("the sum is" + " " + (num1 + num2 + num3));
            Console.WriteLine("Enter the 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sum of no." + " " + (num1+ num2));


        }


    }
}
