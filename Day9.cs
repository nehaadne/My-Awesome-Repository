using System;

namespace MyFirstProject
{
    class Day9
    {
        public static void Main1()
        {
            int salary, bonus, year;
            Console.WriteLine("Enter the Salary");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year");
            year = Convert.ToInt32(Console.ReadLine());
            if (year > 5)
            {
                bonus = salary * 5 / 100;
                Console.WriteLine("Net bonus amount is" + bonus);
            }
            else
            {
                Console.WriteLine("You don't have any bonus amount");
            }



        }
    }
}
