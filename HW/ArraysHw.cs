using System;
using System.Collections;

namespace HW
{
    public class ArraysHw
    {
        public int GetMinValueWithOddIndex(int[] testArray)
        {
            int[] valueWithOddIndex;

            if (testArray.Length % 2 != 0)
            {
                valueWithOddIndex = new int[testArray.Length / 2 + 1];
            }
            else
            {
                valueWithOddIndex = new int[testArray.Length / 2 ];
            }
            

            for (int i = 1, j = 0; i < testArray.Length; i = i + 2, j++)
            {
                valueWithOddIndex[j] = testArray[i];
            }

            Array.Sort(valueWithOddIndex);

            return valueWithOddIndex[0];
        }       
    }
}
