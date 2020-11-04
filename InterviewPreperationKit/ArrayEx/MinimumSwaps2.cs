using System;

namespace InterviewPreperationKit.ArrayEx
{
    public class MinimumSwaps2
    {
        public static int minimumSwaps(int[] arr)
        {
            int min_index = 0;
            int min = arr[0];
            int swaps = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min_index = i;
                    min = arr[i];

                }
            }
            if (min_index != 0)
            {
                int temp = arr[0];
                arr[0] = arr[min_index];
                arr[min_index] = temp;
                swaps++;
            }
            for (int cur = 0; cur < arr.Length -1; cur++)
            {
                int pos = arr[cur] - arr[0];
                while (arr[pos] != arr[cur])
                {
                    int temp = arr[pos];
                    arr[pos] = arr[cur];
                    arr[cur] = temp;
                    swaps++;
                    pos = arr[cur] - arr[0];
                }
                cur = pos;

            }
            return swaps;

            //int swapNumber = 0, expectedFirst = 1;
            //for (int i = 0; i < arr.Length - 1; i++)
            //{

            //    if (arr[i] != expectedFirst)
            //    {
            //        int swapIndex = Array.IndexOf(arr, expectedFirst);
            //        arr[swapIndex] = arr[i];
            //        arr[i] = expectedFirst;
            //        ++swapNumber;
            //    }
            //    ++expectedFirst;
            //}
            //return swapNumber;// swapNumber;
        }
    }
}
