using System;

namespace ArraysAndCollections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Arrays

            //int[] myArray1 = new int[5];

            //// Some part of code

            //myArray1[0] = 1;
            //myArray1[1] = 2;
            //myArray1[2] = 3;
            //myArray1[3] = 4;
            //myArray1[4] = 5;

            //int[] myArray2 = new int[] { 11, 22, 33, 44, 55 };

            ////Arrays.IterationOnArray(myArray2);

            ////for (int i = 0; i < myArray1.Length; i++)
            ////{
            ////    myArray1[i] = 25;
            ////}

            ////myArray1[0] = 100;

            //for (int i = 0; i < myArray1.Length; i++)
            //{
            //    Console.WriteLine(i + " " + myArray1[i]);
            //}

            //// Do not do it!!!
            //object[] objectArray = { 1, true, "11", myArray1};

            //foreach (var obj in objectArray)
            //{
            //    Console.WriteLine(obj);
            //}

            // Collections
            Collections.WorkingWithCollection();

            Console.ReadKey();
        }
    }
}
