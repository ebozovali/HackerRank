using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewPreperationKit.WarmUp
{
   public class CountingValleys
    {
        /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

        public static int countingValleys(int steps, string path)
        {
            int numberOfValleys = 0;
            var pathArr = path.ToCharArray();
            int seaLevel = 0;
            for (int i = 0; i < pathArr.Length; i++)
            {
                if (seaLevel < 0)
                {
                    seaLevel = seaLevel + (path[i] == 'U' ? +1 : -1);
                    numberOfValleys += seaLevel == 0 ? 1 : 0;
                }
                else
                {
                    seaLevel = seaLevel + (path[i] == 'U' ? +1 : -1);
                }

            }

            return numberOfValleys;
        }
    }
}
