using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace InterviewPreperationKit.ArrayEx
{
    public class TwoDArray
    {
        //First challenge of arrays
        // Complete the hourglassSum function below.
       public static int hourglassSum(int[][] arr)
        {
            int largestHourglassSum = 0;
            for (int i = 0; i < arr.Length-2; i++)
            {
                for (int j = 0; j < arr[i].Length-2; j++)
                {
                    int sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i+1][j+1] + arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2];
                    largestHourglassSum = (i == 0 && j == 0) ? sum :  sum > largestHourglassSum ? sum : largestHourglassSum;
                }
            }

            return largestHourglassSum;
        }
    }
}
