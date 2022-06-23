using System;

namespace MyFirstProject
{
    class Day2
    {
        public static void Main31()
        {
            //int n, sqr, last, sum = 0;
            //Console.WriteLine("Enter number");
            //n = int.Parse(Console.ReadLine());
            //sqr = n * n;
            //while(sqr>0)
            //{
            //    last = sqr % 10;
            //    sum = sum + last;
            //    sqr =  sqr / 10;
            //}
            //if (sum == n)
            //{
            //    Console.WriteLine(n + " is neon num");
            //}
            //else
            //{
            //    Console.WriteLine(n + " is not neon num");

            //}
            //Console.WriteLine("Enter the number");
            //int n = int.Parse(Console.ReadLine());
            //int temp = n;
            //int reverse = 0;
            //while(n>0)
            //{
            //    int last = n % 10;
            //    reverse = reverse * 10 + last;
            //    n = n / 10;
            //}
            //if (reverse==temp)
            //{
            //    Console.WriteLine("palindrome");
            //}
            //else
            //{
            //    Console.WriteLine("not palindrome");
            //}

            int mul = 1, n;
            Console.WriteLine("Enter number");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                mul = mul * i;
            }
            Console.WriteLine(mul);
        }

    }
}
