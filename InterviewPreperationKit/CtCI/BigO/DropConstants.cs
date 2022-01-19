using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPreperationKit.CtCI.BigO
{
    public class DropConstants
    {
        //this takes O(N)
        public static void MinMax(int[] arr)
        {
            int min = int.MinValue;
            int max = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] < max) max = arr[i];
            }
        }
        //this takes O(N) not O(2N)
        public static void MinMax2(int[] arr)
        {
            int min = int.MinValue;
            int max = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < max) max = arr[i];
            }
        }
    }
}
