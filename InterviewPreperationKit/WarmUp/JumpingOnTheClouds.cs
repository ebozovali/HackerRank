using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewPreperationKit.WarmUp
{
    public class JumpingOnTheClouds
    {
        // Complete the jumpingOnClouds function below.


        public static int jumpingOnClouds(int[] c)
        {
            int minNumberOfJumps = 0;

            for (int i = 1; i < c.Length; i++)
            {
                if (i+1 < c.Length &&  c[i + 1] == 0 )
                {
                    i++;
                }
                if (i != 0)
                {
                    minNumberOfJumps++;
                }

            }

            return minNumberOfJumps;
        }
    }
}
