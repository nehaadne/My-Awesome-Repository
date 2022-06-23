using System;

namespace MyFirstProject
{
    class Employee
    {
        public float salary = 40000;
    }
    class Programmer : Employee
    {
        public float bonus = 10000;
    }
    class TestInheritance
    {
        public static void Main1(string[] args)
        {
            Programmer p1 = new Programmer();
            Console.WriteLine("salary " + p1.salary);
            Console.WriteLine("bonus " + p1.bonus);


        }
    }
}
