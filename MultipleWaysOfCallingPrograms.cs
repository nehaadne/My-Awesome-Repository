using System;

namespace MyFirstProject
{
    class MultipleWaysOfCallingPrograms
    // this is a class
    {
        // feature 
        // int num1=0, num2=0;
        // 1st method
        public static void Main1()
        {
            // OOP - Object Oriented Programming
            // class - group of similar objects  - Table
            //object - has  feature/property and  function 
            // object feature/property  - 4 leg, material - wooden, height, weight
            // function - capacity() - weigth hold

            //Example -  Car
            // feature - color, tyres, weight, model, fuel_type, seater
            // function - speed(), power_window()
            // Car objects - MAruti, Audi, Nano, Scorpio

            //int num1, num2;   // feature of class


            Console.WriteLine("Main method starts");

            // syntax to create an object :-  classname objectname = new classname
            MultipleWaysOfCallingPrograms callprint = new MultipleWaysOfCallingPrograms();
            // calling method using object - objectname.methodname();
            callprint.print();// non static - create an object and call print
            // static method will call only static method
            readMethod(); //static - allowed

            //SYNTAX - calling a method from different class
            // classname objectname = new classname();
            //new - is a keyword to create an object
            Shapes square = new Shapes();
            square.quad_Area(); // method calling
            Shapes.Print(16); // static method of another class
            square.square_Perimeter(); // method calling
            Console.WriteLine("Main method end");
        }

        // 2nd method - this is used to print the values
        public void print()
        {
            Console.WriteLine("this is a non static Print Method");
        }
        // 3rd method - this is used to read the value
        public static void readMethod()
        {
            Console.WriteLine("this is a static Read Method");
        }
    }

    class Shapes
    {
        // rectangle, square, circle, triangle;
        int area, length = 10, breadth = 12, perimeter;

        public void quad_Area()
        {
            //square = side* side
            //rectangle = l*b 
            // triangle = .5 * h * b
            // circle = 3.14 * r*r
            area = length * breadth;
            Print(area);
            // Console.WriteLine("Area of a Square is " + area); 
        }
        public void square_Perimeter()
        {
            //square = side+side
            //rectangle = 2(l+b) 
            // triangle = side+side+side
            // circle = 2*3.14*r
            perimeter = length + breadth;
            //Console.WriteLine("Perimeter of a Square is " + perimeter);
            Print(perimeter);
        }
        public static void Print(int result)
        {
            Console.WriteLine("print method of Shapes class " + result);
            MultipleWaysOfCallingPrograms day10 = new MultipleWaysOfCallingPrograms();
            day10.print(); // non static calling
            MultipleWaysOfCallingPrograms.readMethod(); // static calling
        }
    }

}

