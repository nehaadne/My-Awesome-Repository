using System;

namespace MyFirstProject
{
     class array_practice
    {
        public static void Main2()
        {
            //int num, i;
            //Console.WriteLine("Enter the number");
            //num = Convert.ToInt32(Console.ReadLine());
            //int sum = 0, mult = 1, rem;

            //while (!=0)
            //{
            //    if (i%5!=0 || i%10!=0)
            //    {
            //        Console.WriteLine(" " + i);
            //    }
            //}
            //******Spy number program******
            //                int num, i;
            //Console.WriteLine("Enter the number");
            //num = Convert.ToInt32(Console.ReadLine());
            //int sum = 0, mult = 1, rem;

            //while (num != 0)
            //{
            //    rem = num % 10;
            //    sum += rem;
            //    mult *= rem;
            //    num /= 10;
            //}
            //if (sum == mult)
            //    Console.WriteLine("It is Spy number");
            //else
            //    Console.WriteLine("It is not Spy number");
            // *********Trimorphic*********

            //int num;
            //Console.WriteLine("Enter the number");
            //num = Convert.ToInt32(Console.ReadLine());
            //int temp = 0;
            //int cube_power = num * num * num;
            //while (num != 0)
            //{
            //    if(num%10!= cube_power%10)
            //    {
            //        temp = 1;
            //        break;
            //    }
            //    num /= 10;
            //    cube_power /= 10;

            //}
            //if (temp == 0)
            //    Console.WriteLine("It it trimorphic no");
            //else
            //    Console.WriteLine("It is not trimorphic no");
            //***peramid***
            int i, j;
            for(i=1; i < 5 ; i++)
            {
                for(j=1; j<=9; j++)
                {
                    if (j + i < 5 || j - i > 3)
                        Console.Write(" ");
                    else
                        Console.Write(i);
                }
                Console.WriteLine(" ");

            }
        }
    }
}
