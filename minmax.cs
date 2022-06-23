using System;

namespace MyFirstProject
{
     class minmax
    {
        public static void Main12()
        {
            int[] num = { 10, 20, 60, 50, 100 };
            int i, max, min, n;
            n = 5;
            max = num[0];
            min = num[0];
            for (i=1; i<n; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];

                }
                if (num[i] < min)
                {
                   min = num[i];
                }
            }
            Console.WriteLine("Maximum elements " + max);
            Console.WriteLine("Minimum elements " + min);
        }
    }
}
