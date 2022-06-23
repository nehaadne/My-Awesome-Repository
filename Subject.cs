using System;

namespace MyFirstProject
{
    class Subject
    {
        public static void Main1()
        {
            int sub1, sub2;
            Console.WriteLine("Enter 1st sub marks");
            sub1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd sub marks");
            sub2 = int.Parse(Console.ReadLine());
            if(sub1 > 50 && sub2 > 50)
            {
                Console.WriteLine("pass");
            }
            else
            {
                Console.WriteLine("fail");
            }


        }
    }
}
