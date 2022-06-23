using System;

namespace MyFirstProject
{
     class NaturalNAddAvg
    {
        public static void Main2()
        {
            int counter,num, sum = 0;
            double avg;
            for(counter = 1; counter<= 10; counter++)
            {
                Console.WriteLine("Enter the number " +counter);
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }
            avg = sum / 10;
            Console.WriteLine("The sum of 10 no is : {0}\nThe Average is : {1}\n", sum, avg);
        }
    }
}
