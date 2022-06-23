using System;

namespace MyFirstProject
{
     class Day7IncrementOp
    {
        public static void Main1()
        {
            int result, number;
            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());
            //Unary Operator ++, --
            /* - unary operator takes 1 operand
               - Increment :-post and pre
               - post increment -number++ - 1st it uses then increment the value by 1
               - pre increment -++number - 1st it increse the value then it will use it
               - ++-this means + 1
               - result = number + 1*/
            // result = number++;
            // result = ++number;

            // result = --number;
            result = number++;
            number = 8;
            result = number + result;


            Console.WriteLine("unary example \n number is {0}, result is {1} ", number, result);
            number = --result;
            Console.WriteLine("unary example \n number is {0}, result is {1} ", number, result);
            result++;
            Console.WriteLine("unary example \n number is {0}, result is {1} ", number, result);


        }

    }
}
