using System;

namespace MyFirstProject
{
    class age
    {
        public static void Main1()
        {
            int age;
            Console.WriteLine("Enter the age");
            age = int.Parse(Console.ReadLine());
            if (age <=18)
            {
                Console.WriteLine("person is in teenage", age);
            }
            else
            {
                Console.WriteLine("person is not in teenage", age);
            }
        }
    }
}
