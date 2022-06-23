/////* Frequency of number*/

////using System;

////namespace MyFirstProject
////{
////    class Class2
////    {
////        public static void Main09()
////        {
////            Console.WriteLine("Enter mobile number");
////            long mb = long.Parse(Console.ReadLine());
////            long temp = mb;
////            for(int i=0;i<=10;i++)
////            {
////                int c = 0;
////                while(mb>0)//8446655088
////                {
////                    long last = mb % 10;//8
////                    if (last == i)//f
////                        c++;
////                     mb /= 10;//8
////                }
////                mb = temp;//8
////                if(c>0)
////                    Console.WriteLine("Freq of "+i+" = "+c);
////            }
////        }
////    }
////}


//using System;

//namespace MyFirstProject
//{
//    class Class3
//    {
//        public static void Main()
//        {
//            string name = "neha";
//            int i, len;
//            int vowel_count = 0;
//            int cons_count = 0;
//            len = name.Length;
//            for (i = 0; i < len; i++)
//            {
//                if (name[i] == 'a' || name[i] == 'e' || name[i] == 'i' || name[i] == 'i' || name[i] == 'o')
//                {
//                    vowel_count++;
//                }
//                else
//                {
//                    cons_count++;
//                }
//            }
//            Console.WriteLine("vowels in the string " + vowel_count);

//        }

//    }
//}

