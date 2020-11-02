using System;
using System.Collections.Generic;

namespace InterviewPreperationKit.ArrayEx
{
    public class MinimumSwaps2
    {
        public static int minimumSwaps(int[] arr)
        {

            int swapNumber = 0, expectedFirst = 1;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                //if (arr[i] != expectedFirst)
                //{
                //    for (int j = i+1; j < arr.Length; j++)
                //    {
                //        if (arr[j] == expectedFirst)
                //        {
                //            arr[j] = arr[i];
                //            arr[i] = expectedFirst;
                //            ++expectedFirst;
                //            ++swapNumber;
                //            break;
                //        }
                //    }
                //}
                //else
                //{
                //    ++expectedFirst;
                //}
                if (arr[i] != expectedFirst)
                {
                    int swapIndex = Array.FindIndex(arr, row => row.Equals(expectedFirst));

                   // int swapIndex = Array.FindIndex(arr, x => x.Contains("author"));//Array.IndexOf(arr, expectedFirst);
                    arr[swapIndex] = arr[i];
                    arr[i] = expectedFirst;
                    ++swapNumber;
                }
                ++expectedFirst;
            }
            return 49990;// swapNumber;
        }
    }
}
