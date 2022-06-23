using System;

namespace MyFirstProject
{
    class TwoInteger
    {
        public static void Main1()
        {
            int Int1, Int2;
            Console.WriteLine("Enter 1st num");
            Int1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd num");
            Int2 = int.Parse(Console.ReadLine());
            if (Int1 == Int2)
            {
                Console.WriteLine("Bothe Integers are equal", Int1, Int2);
            }
            else
            {
                Console.WriteLine("Bothe Integers are not equal", Int1, Int2);
            }
            
        }
    }
}
