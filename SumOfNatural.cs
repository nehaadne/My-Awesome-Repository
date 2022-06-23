using System;

namespace MyFirstProject
{
     class SumOfNatural
    {
        public static void Main2()
        {
            int counter, Sum = 0;

            for (counter = 1; counter <= 7; counter++)
            {
                Sum += counter;
                Console.WriteLine("{0} " , counter);
            }
            
                Console.WriteLine("The Sum is " + Sum);

            



        }
    }
}
