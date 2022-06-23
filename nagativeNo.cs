using System;

namespace MyFirstProject
{
     class nagativeNo
    {
        public static void Main3()
        {
            int[] arr = new int[100];
            int i, num;

           
            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Enter elements in array: ");
            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("All negative elements in array are: ");
            for (i = 0; i < num; i++)
            {
                //Printing negative elements
                if (arr[i] < 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            Console.ReadLine();

        }
    }
}