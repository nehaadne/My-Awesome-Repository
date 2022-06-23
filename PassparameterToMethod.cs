using System;

namespace MyFirstProject
{
    class PassparameterToMethod
    {
        public static void Main2()
        {
            int num1, num2;
            Console.WriteLine("Enter 1st number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1st number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Arithmetic arth = new Arithmetic();
            arth.Sum(num1, num2);
            

        }
    }

    class Arithmetic
    {
        public void Sum(int n1, int n2)
        {
            int Sum = n1 + n2;
            Print(Sum);

        }
        public void Print(int result)
        {
            Console.WriteLine(result);
        }

    }
}
