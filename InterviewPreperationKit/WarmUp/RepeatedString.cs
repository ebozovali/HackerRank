using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewPreperationKit.WarmUp
{
   public class RepeatedString
    {

        // Complete the repeatedString function below.
        public static long repeatedString(string s, long n)
        {
            long numberOfOccurences=0;
            long k = n / s.Length;
            long count = 0;
            count = s.Count(x => x == 'a');
            numberOfOccurences = count * k;
            long remainingChars = n % s.Length ;
            string ss = new String(s.ToCharArray(), 0,(int) remainingChars) ;
            count = 0;
            count = ss.Count(x => x == 'a');
            numberOfOccurences += count;



            return numberOfOccurences;
        }
    }
}
