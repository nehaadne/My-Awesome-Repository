using System;

namespace MyFirstProject
{
    class reverse
    {
        public static void Main2()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Original array: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Array in reverse order: ");
            //Loop through the array in reverse order  
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write(a[i] + " ");
            }

                 for (int j = a.Length; j>0; j--)
                {
                    if (j % 2 == 0)
                    {
                    Console.Write("\n");
                        Console.Write("Backwards elements " + j);
                    }
                }
            }
        }
    }

