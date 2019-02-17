using System;

namespace Loops
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //// While
            //string counter = "A";

            //while (counter != "AB")
            //{
            //    Console.WriteLine(counter);
            //    counter += "B";
            //}


            //// Do-While
            //int counter = 100;

            //do
            //{
            //    Console.WriteLine(counter);
            //    counter++;

            //} while (counter < 10);

            //// For
            //for (int i = 0; i < 10; i = i + 2)
            //{
            //    Console.WriteLine(i);
            //}

            // Foreach

            string testString = "ABCDE";
            var charArray = testString.ToCharArray();

            //// Change with for
            //for (int i = 0; i < charArray.Length; i++)
            //    {
            //        charArray[i] = 'A';
            //        Console.WriteLine(charArray[i]);
            //    }

            //// Break keyword
            //foreach (var item in charArray)
            //{
            //    Console.WriteLine(item);
            //    if (item == 'C')
            //    {
            //        break;
            //    }
            //}

            //// Continue keyword
            //foreach (var item in charArray)
            //{
            //    if (item == 'B' || item == 'C')
            //    {
            //        continue;
            //    }
            //    if (item == 'D')
            //    {
            //        break;
            //    }
            //    Console.WriteLine(item);                
            //}

            // Can not do in such way
            //foreach (var symbol in testString.ToCharArray())
            //{
            //    symbol = 'A';
            //    Console.WriteLine(symbol);
            //}

            
            //// Different place of i++. have different behavior of the loop
            //for (int i = 0; i < charArray.Length; i++)
            //{
            //    charArray[i] = 'A';
            //    Console.WriteLine(charArray[i]);
            //    if (i < charArray.Length)
            //    {
            //        continue;
            //    }
            //    //i++;
            //}


            Console.ReadKey();
        }
    }
}
