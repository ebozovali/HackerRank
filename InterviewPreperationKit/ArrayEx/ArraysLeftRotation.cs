using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPreperationKit.ArrayEx
{
    public class ArraysLeftRotation
    {
        public static int[] rotLeft(int[] a, int d)
        {
            d = d % a.Length;
            var tempArr = new int[d];
            Array.Copy(a,0,tempArr,0,d);

            Array.Copy(a, tempArr, d);
            Array.Copy(a, d, a, 0, a.Length - d);
            Array.Copy(tempArr, 0, a, a.Length - d, d);

            return a;

        }
    }
}
