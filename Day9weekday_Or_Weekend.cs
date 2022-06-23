using System;


namespace MyFirstProject
{
     class Day9weekday_Or_Weekend
    {
        public static void Main1()
        {
            int week;
            Console.WriteLine("Enter a day");
            week = Convert.ToInt32(Console.ReadLine());
            if (week == 1)
                Console.WriteLine("Monday");

            else if (week == 2)

                Console.WriteLine("Tuesday");
            else if (week == 3)
                Console.WriteLine("Wednesday");
            else if (week == 4)
                Console.WriteLine("Thursday");
            else if (week == 5)
                Console.WriteLine("Friday");
            else if (week == 6)
                Console.WriteLine("Saturday");
            else
                Console.WriteLine("Its a Weekend");
        }
    }
}
