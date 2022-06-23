using System;

namespace MyFirstProject
{
    class Asterisk_Alphabet
    {
        public static void Main1()
        {
            int row, column;

            Console.Write("Display the pattern like 'N' with an asterisk:\n");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || column == 5 || row == column && column != 0 && column != 6)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

    }
}


