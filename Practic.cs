using System;

namespace MyFirstProject
{
     class Practic
    {
        public static void Main2()
        {
            string week;
            Console.WriteLine("Enter a Day");
            week = Console.ReadLine();
            if (week == "Monday" || week == "Tuesday" || week == "Wednesday" || week == "Thrusday" || week == "Friday" ||
                week == "Saturday")
            {
                Console.WriteLine("Its a WeekDay");
            }
            else if (week == "Sunday")
            {
                Console.WriteLine("Its a Weekend");
            }
                   
            /*int num = 10, result;
            result = num++;
            result += result;
            result = num >> 3;
            Console.WriteLine(result);*/
            //int num1, num2=0, num3=0, output=0;
            
            //Console.WriteLine("Enter any number");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //num1--;
            //Console.WriteLine("num1 = {0} num2 = {1} num3 = {2} output = {3} ", num1, num2, num3, output);

            //output = 40;
            //num2 = output;
            //output = num2--;
            //Console.WriteLine("num1 = {0} num2 = {1} num3 = {2} output = {3} ", num1, num2, num3, output);

            //num3 = num2 + num1;
            //num3--;
            //output = --num3;
            //Console.WriteLine("num1 = {0} num2 = {1} num3 = {2} output = {3} ", num1, num2, num3, output);
        }

    }
}
