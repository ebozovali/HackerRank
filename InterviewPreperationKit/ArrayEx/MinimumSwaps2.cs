using System;

namespace InterviewPreperationKit.ArrayEx
{
    public class MinimumSwaps2
    {
        public static int minimumSwaps(int[] arr)
        {


            int swapNumber = 0, expectedFirst = 1;
            for (int i = 0; i < arr.Length - 1; i++)
            {

                if (arr[i] != expectedFirst)
                {
                    int swapIndex = Array.IndexOf(arr, expectedFirst);
                    arr[swapIndex] = arr[i];
                    arr[i] = expectedFirst;
                    ++swapNumber;
                }
                ++expectedFirst;
            }
            return swapNumber;// swapNumber;
        }
    }
}
