using System;

namespace MyFirstProject
{
    class _2Darray
    {
        public static void Main2()
        {

            int[,] arr = new int[3, 3];
            // WAP to print all the diagonal elements of the matrix{11,15,19}

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    arr[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (row == 0)// bool
                        Console.WriteLine(arr[row, col]);
                }

            }
        }
    }
}