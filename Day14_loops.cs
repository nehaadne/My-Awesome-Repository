using System;

namespace MyFirstProject
{
     class Day14_loops
    {
        public static void Main2()
        {
            int counter;
            counter = 0;
            while (counter < 10)
            {
                
                if (counter % 2 == 0)
                {
                    Console.WriteLine("even " +counter);
                }
                else
                {
                    Console.WriteLine("odd " + counter);

                }
                counter++;
            }
        }
    }
}
