using InterviewPreperationKit.ArrayEx;
using NUnit.Framework;
using System;
using System.IO;
using System.Linq;



namespace InterviewPreparationKit.Test.Array
{
    public class MinimumSwaps2Test
    {
        [Test]
        public void TestCase0()
        {
            //Arrange
            string fileName = "input00.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"Array\Data\MinimumSwaps2\input\", fileName);
            String input = File.ReadAllText(path);
            int numTasks = int.Parse(input.Split('\n')[0].Trim().Split(' ')[0]);
            for (int i = 1; i <= numTasks; i++)
            {
                int j = 0;
                int arrLength = int.Parse(input.Split('\n')[i*2 - 1].Trim().Split(' ')[0]);
                int[] arr = new int[arrLength];
                foreach (var col in input.Split('\n')[i * 2 ].Trim().Split(' '))
                {
                    arr[j] = int.Parse(col.Trim());
                    j++;
                }
                //Act
                var m=NewYearChaos.minimumBribes(arr);
                //Assert
                switch (i)
                {
                    case 1:
                Assert.AreEqual("3", m);
                        break;
                    case 2:
                        Assert.AreEqual("Too chaotic", m);
                        break;
                    default:
                        break;
                }
            }



        }
      
    }
}
