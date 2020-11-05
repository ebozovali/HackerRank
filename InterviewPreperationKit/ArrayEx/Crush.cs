using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPreperationKit.ArrayEx
{
    public class Crush
    {
        public static long crush(int n, int[][] queries)
        {
            long[] arr = new long[n];

            for (int i = 0; i < queries.Length; i++)
            {
                    int a = queries[i][0], b = queries[i][1], k = queries[i][2];
                    arr[a - 1] += k;
                    arr[b] -= k; // see comment at end of code
            }
            //https://github.com/RodneyShag/HackerRank_solutions/blob/master/Data%20Structures/Arrays/Algorithmic%20Crush/Solution.java
            /* Find max value */
            long sum = 0;
            long max = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
                max = Math.Max(max, sum);
            }
            return max;
        }
    }
}
