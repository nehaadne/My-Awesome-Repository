using System;

namespace MyFirstProject
{
    class AreaOfCircle
    {
        public static void Main1()
        {
            double Area, Radious;
                Console.Write("Enter Radius: ");
                Radious = Convert.ToDouble(Console.ReadLine());
                Area = Math.PI * Radious * Radious;
                Console.WriteLine("Area of circle: " + Area);
                Console.ReadKey();
            }
        }
    }
