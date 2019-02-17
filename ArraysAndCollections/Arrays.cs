namespace ArraysAndCollections
{
    public class Arrays
    {
        int[] myArray;

        int[] myArray1 = new int[5];

        int[] myArray2 = new int[] { 11, 22, 33, 44, 55 };

        int[] myArray3 = { 111, 222, 333, 444, 555};

        public static void IterationOnArray(int[] array)
        {
            foreach (var item in array)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
