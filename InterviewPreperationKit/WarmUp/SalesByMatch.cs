using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewPreperationKit.WarmUp
{
   public class SalesByMatch
    {
        // Complete the sockMerchant function below.
        public static int sockMerchant(int n, int[] ar)
        {
            Array.Sort(ar);
            int pairedSockNumber=0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (i+1 < ar.Length && ar[i] == ar[i+1])
                {
                    i++;
                    pairedSockNumber++;
                }
             
            }
            return pairedSockNumber;
        }
    }
}
