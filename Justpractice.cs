using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class Justpractice
    {
        public static void Main21()
        {
            //for(int i=4; i<=40; i=i+4)
            //{
            //    Console.WriteLine(i);


            //}
            //Console.WriteLine("\n");

            //for(int j=1; j<=10; j++)
            //{
            //    int sqr = (j * j);
            //    {
            //        Console.WriteLine(sqr);
            //    }
            //}


            //Console.WriteLine("Enter number");
            //int n = int.Parse(Console.ReadLine());
            //for(int i=1; i<11; i++)
            //{
            //    Console.WriteLine(n + "X" + "=" + n * i);
            //}


            //    int mul=1, n;
            //    Console.WriteLine("Enter number");
            //    n = int.Parse(Console.ReadLine());
            //    for(int i=1; i<=n; i++)
            //    {
            //        mul = mul * i;
            //    }
            //    Console.WriteLine(mul);
            //}

            int c=0;
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                   // Console.WriteLine(i);
                     c++;
                }
            }
            //Console.WriteLine("count =" + c);
            if(c==2)
            {
                Console.WriteLine("prime number");
            }
            else
            {
                Console.WriteLine( "not prime");
            }
        }
    }
}
