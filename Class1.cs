using System;

namespace MyFirstProject
{
    class Class1
    {
        public static void Main10(string[] args)
        {

            for(char r='A'; r<='F'; r++)
            {
                for(char c='A'; c<=r; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            for(char r='E'; r>='A';r--)
            {
                for(char c='A'; c<=r;c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }


            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    
                    Console.Write(c%2);
                }
                Console.WriteLine();
            }
            int k = 0;
            for (int r = 1; r <= 4; r++)
            {
                for (int c = 1; c <= r; c++)
                {

                    Console.Write(k);
                    k++;
                }
                Console.WriteLine();
            }
            
            for(int r=1;r<=5;r++)
            {
                for(int space=r; space<=4;space++)
                {
                    Console.Write(" ");
                }
                for(int c=1;c<=r;c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
                
            }

            /*

            *
            ***
            *****
            *******

             */

            //Console.WriteLine("Enter no of line");
            //int line = int.Parse(Console.ReadLine());
            //for (int r=1; r<=line; r++)
            //{
            //    for(int sp=1; sp<=line-r;sp++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int c=1; c<2*r;c++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            for(int i=1;i<=5; i++)

            {
               // for(int j=1;j>=i;j--)
                    for (int j = i; j >= 1; j--)
                    {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
                



            //for(int r=1; r<=10; r++)
            //{
            //    for(int c=1; c<=10; c++)
            //    {
            //        if(c==1||r==10)
            //         Console.Write("*");//L
            //        else
            //       Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int r = 1; r <= 10; r++)
            //{
            //    for (int c = 1; c <= 10; c++)
            //    {
            //        if (c == 5 || r == 1)
            //            Console.Write("*");//T
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int r = 1; r <= 10; r++)
            //{
            //    for (int c = 1; c <= 10; c++)
            //    {
            //        if (c == 5 || r == 1|| r==10)
            //            Console.Write("*");//I
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int r = 1; r <= 10; r++)
            //{
            //    for (int c = 1; c <= 10; c++)
            //    {
            //        if (c == 1 || r == 5 || r == 10|| r==1)//E
            //            Console.Write("*");
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int r = 1; r <= 10; r++)
            //{
            //    for (int c = 1; c <= 10; c++)
            //    {
            //        if (c == 1 || r == 5 || r == 1)//F
            //            Console.Write("*");
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int r = 1; r <= 10; r++)
            //{
            //    for (int c = 1; c <= 10; c++)
            //    {
            //        if (c == 1 || r == 5  || r == 1||(r<=5&&c==10))//P
            //            Console.Write("*");
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int r = 1; r <= 10; r++)
            //{
            //    for (int c = 1; c <= 10; c++)
            //    {
            //        if (c == 1 || c == 10 || r == 1 ||r == 10)//O
            //            Console.Write("*");
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int r = 1; r <= 10; r++)
            //{
            //    for (int c = 1; c <= 10; c++)
            //    {
            //        if ((c == r || c == 1 || c == 10) && (c == 1 || r == 5 || r == 10 || r == 1) ||
            //            (c == 1 || r == 5 || c == 10) || (c == 1 || r == 5 || c == 10 || r == 1))
            //            console.write("*");
            //        else
            //            console.write(" ");
            //    }
            //    console.writeline();
            //}


            //for (int r = 1; r <= 10; r++)
            //{
            //    for (int c = 1; c<=46; c++)
            //    {
            //        if (c <= 12)
            //        {
            //            if (c == r || c == 1 || c == 10)
            //                // && (c == 1 || r == 5 || r == 10 || r == 1) &&
            //                //(c == 1 || r == 5 || c == 10) && (c == 1 || r == 5 || c == 10 || r == 1))
            //                // if (c == 1 || r == 5 || c == 10 || r == 1)//A

            //                Console.Write("*");
            //            else
            //                Console.Write(" ");
            //        }
            //        else if (c >= 15 && c <= 22)
            //        {
            //            if (c == 15 || r == 5 || r == 10 || r == 1)
            //                Console.Write("*");
            //            else
            //                Console.Write(" ");
            //        }

            //        else if (c >= 24 && c <= 34)
            //        {
            //            if (c == 24 || r == 5|| c==34)
            //               Console.Write("*");
            //            else
            //                Console.Write(" ");
            //        }
            //        else if (c >= 36&& c<=46)
            //        {
            //            if ( r == 5 || c == 36 || r == 1||c==46)
            //                Console.Write("*");
            //            else
            //                Console.Write(" ");
            //        }

            //    }
            //    Console.WriteLine();
            //}

            /*

             * 
             * *
             * * *
             * * * *  */

            //*****
            //****
            //***
            //**
            //*

            //for (int r = 1; r <= 5; r++)
            //{
            //    for (int c = r; c >= 1; c--)
            //    {
            //        Console.Write(c);
            //    }
            //    Console.WriteLine();
            //}


            //for (int r = 1; r <= 5; r++)
            //{
            //    for (int c = r; c >= 1; c--)
            //    {
            //        Console.Write(c);
            //    }
            //    Console.WriteLine();
            //}


            //for (int r = 1; r <= 5; r++)
            //{
            //    for (int c = r; c <= 5; c++)
            //    {
            //        Console.Write(c);
            //    }
            //    Console.WriteLine();
            //}

            //for (int r = 5; r >= 1; r--)
            //{
            //    for (int c = r; c >= 1; c--)
            //    {
            //        Console.Write(c);
            //    }
            //    Console.WriteLine();
            //}

            //for (int r = 4; r >= 1; r--)
            //{
            //    for (int c = r; c <= 5; c++)
            //    {
            //        Console.Write(c);
            //    }
            //    Console.WriteLine();
            //}

            //    for(int r=1;r<=5;r++)
            //    {
            //        for(int c=1;c<=5;c++)
            //        {
            //            if(c%2==0)
            //                Console.Write("@");
            //            else
            //                Console.Write("#");
            //        }
            //        Console.WriteLine();
            //    }

            //    for (int r = 1; r <= 5; r++)
            //    {
            //        for (int c = 1; c <= r; c++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
        }

    }
}











