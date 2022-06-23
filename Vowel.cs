using System;

namespace MyFirstProject
{
    class Vowel
    {
        public static void Main1()
        {
            char character;
            Console.WriteLine("Enter vowel");

            character = Convert.ToChar(Console.ReadLine());
            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                Console.WriteLine(character + " is vowel");
            else
                Console.WriteLine(character + " is not vowel");

        }
    }
}
