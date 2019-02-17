using System.Collections.Generic;

namespace ArraysAndCollections
{
    public class Collections
    {
        public static List<string> myList = new List<string>();

        public static Dictionary<string, int> myDictionary = new Dictionary<string, int>();

        public static void WorkingWithCollection()
        {
            //myList.Add("First");
            //myList.Add("Some item");
            //myList[1] = "First new";

            //System.Console.WriteLine(myList.Capacity);

            //foreach (var item in myList)
            //{
            //    System.Console.WriteLine(item);
            //}

            //System.Console.WriteLine("Start capacity is " + myList.Capacity);

            //for (int i = 1; i < 100; i++)
            //{
            //    myList.Add("test");
            //    System.Console.WriteLine(i + " " + myList.Capacity);
            //}

            myDictionary.Add("first item", 1);
            myDictionary.Add("second item", 2);
            myDictionary.Add("third item", 3);

            //int valueByKey;

            //myDictionary.TryGetValue("first item", out valueByKey);
            //System.Console.WriteLine(valueByKey);

            var keys = myDictionary.Keys;

            foreach (var key in keys)
            {
                System.Console.WriteLine(key);
            }

            var values = myDictionary.Values;

            foreach (var value in values)
            {
                System.Console.WriteLine(value);
            }

            //System.Console.WriteLine("Count is " + myList.Count);
        }
    }
}
