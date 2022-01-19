using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPreperationKit.CtCI.BigO
{
    public class SpaceComplexity
    {
        //this takes O(n) time and O(n) space.
        public static int Sum(int n)
        {
            if (n <= 0)
                return 0;
            return n + Sum(n - 1);
        }

        //this takes O(n) time and O(1) space.
        public static int pairSumSequence(int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += pairSum(i, i + 1);
            }
            return sum;
        }

        private static int pairSum(int i, int v)
        {
            return i + v;    
        }
    }
}
