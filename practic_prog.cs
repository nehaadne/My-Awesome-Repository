using System;
using System.Text;

namespace MyFirstProject
{
    class practic_prog
    {
        public static void Main2()
        {
            {
                // declaring and initializing the array
                int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };

                int temp=0;

                // traverse 0 to array length
                for (int i = 0; i < arr.Length-1;i++)

                    // traverse i+1 to array length
                    for (int j = i + 1; j <arr.Length; j++)
                        // compare array element with 
                        // all next element
                        if (arr[i] < arr[j])
                        {

                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }

                // print all element of array
                foreach (int value in arr)
                {
                    Console.Write(value + " ");
                }

            }
        }
    }
}
