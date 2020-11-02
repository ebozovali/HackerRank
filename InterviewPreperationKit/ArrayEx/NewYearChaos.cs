
namespace InterviewPreperationKit.ArrayEx
{
    public class NewYearChaos
    {
        public static string minimumBribes(int[] q)
        {
            int minNumBribe = 0;
            string m = "";
            bool chaotic = false;
            int expectedFirst = 1, expectedSecond = 2, expectedThird = 3;

            for (int i = 0; i < q.Length; i++)
            {
                if (q[i] == expectedFirst)
                {
                    expectedFirst = expectedSecond;
                    expectedSecond = expectedThird;
                    ++expectedThird;
                }
                else if (q[i] == expectedSecond)
                {
                    ++minNumBribe;
                    expectedSecond = expectedThird;
                    ++expectedThird;
                 }
                else if (q[i] == expectedThird)
                {
                    minNumBribe+=2;
                    ++expectedThird;
                }
                else
                {
                    chaotic = true;
                    break;
                }
            }
            if (chaotic)
            {
                // Console.WriteLine("Too chaotic");
                m = "Too chaotic";
                return m;
            }
            else
                //    Console.WriteLine(minNumBribe.ToString());
                return minNumBribe.ToString();


        }
    }
}
