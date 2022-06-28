using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShauryaCSharpTraining
{
    class Deligates2
    {
        static int add(int a, float b, long c)
        {
            return (int)(a + b + c);
        }
        static void greet(string nm)
        {
            Console.WriteLine("Good Afternoon, "+nm);
        }
        static bool isEven(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            //List<int> l1 = new List<int>() { 23, 45, 67, 88, 90, 2, 45, 66 };
            //List<int> l3 = l1.FindAll((a) => a % 2 == 0);
            Func<int, float, long, int> f1 = add;
            int ans = f1(10, 3.4f, 901);
            Action<string> f2 = greet;
            f2("Jivan");
            Predicate<int> f3 = isEven;
            Console.WriteLine(f3(6));
        }
    }
}
