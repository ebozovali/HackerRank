using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPreperationKit.CtCI.BigO
{
    public class Search
    {
        // time complexity of the algorithm is O(n). 
        public static int LinearSearch(int[] arr,int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (x == arr[i])
                {
                    return i;
                }
            }
            return - 1;
        }
    }
}
