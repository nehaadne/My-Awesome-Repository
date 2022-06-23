using System;

namespace MyFirstProject
{
    class PositiveandNegative
    {
        public static void Main1()
        {
            int num;
            Console.WriteLine("Check whether num is postitive or negative");
            num = int.Parse(Console.ReadLine());
            if(num >= 0)
            {
                Console.WriteLine("Number is positive", num);
            }
            else
            {
                Console.WriteLine("Number is negative", num);
            }

        }
    }
}
