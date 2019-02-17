using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            //// If-else
            //int a = 5;
            //int b = 6;

            //if (a < b || b != 0)
            //{
            //    Console.WriteLine(a);
            //}
            //else if (a < b)
            //{
            //    Console.WriteLine(b);
            //}
            //else
            //{
            //    Console.WriteLine("Numbers are equal.");
            //}

            // Switch
            int monthNumber = 12;

            switch (monthNumber)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Winter");
                    break;

                case 3:
                    Console.WriteLine("Spring");
                    break;

                case 6:
                    Console.WriteLine("Summer");
                    break;

                default:
                    Console.WriteLine("Month nomber is wrong. " +
                        "Should be from 1 to 12.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
