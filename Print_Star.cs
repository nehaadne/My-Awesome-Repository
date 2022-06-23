using System;

namespace MyFirstProject
{
     class Print_Star
    {
        public static void Main1()
        {
            int num = 1;
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int row=1; row<=n; row++)
            {
                for(int col=1; col<=row; col++)
                {
                    Console.Write(num++);
                }
                Console.Write("\n");
            }
        }
    }
}
