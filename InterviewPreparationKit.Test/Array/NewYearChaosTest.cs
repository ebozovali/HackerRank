using InterviewPreperationKit.ArrayEx;
using NUnit.Framework;
using System;
using System.IO;
using System.Linq;



namespace InterviewPreparationKit.Test.Array
{
    public class NewYearChaosTest
    {

        [Test]
        public void TestCase0()
        {
            //Arrange
            string fileName = "input00.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"Array\Data\NewYearChaos\input\", fileName);
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
                var m=NewYearChaos.MinimumBribes(arr);
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
        [Test]
        public void TestCase1()
        {
            //Arrange
            string fileName = "input01.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"Array\Data\NewYearChaos\input\", fileName);
            String input = File.ReadAllText(path);
            int numTasks = int.Parse(input.Split('\n')[0].Trim().Split(' ')[0]);
            for (int i = 1; i <= numTasks; i++)
            {
                int j = 0;
                int arrLength = int.Parse(input.Split('\n')[i * 2 - 1].Trim().Split(' ')[0]);
                int[] arr = new int[arrLength];
                foreach (var col in input.Split('\n')[i * 2].Trim().Split(' '))
                {
                    arr[j] = int.Parse(col.Trim());
                    j++;
                }
                //Act
                var m = NewYearChaos.MinimumBribes(arr);
                //Assert
                switch (i)
                {
                    case 1:
                        Assert.AreEqual("Too chaotic", m);
                        break;
                    case 2:
                        Assert.AreEqual("7", m);
                        break;
                    default:
                        break;
                }
            }



        }
        [Test]
        public void TestCase2()
        {
            //Arrange
            string fileName = "input11.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"Array\Data\NewYearChaos\input\", fileName);
            String input = File.ReadAllText(path);
            int numTasks = int.Parse(input.Split('\n')[0].Trim().Split(' ')[0]);
            for (int i = 1; i <= numTasks; i++)
            {
                int j = 0;
                int arrLength = int.Parse(input.Split('\n')[i * 2 - 1].Trim().Split(' ')[0]);
                int[] arr = new int[arrLength];
                foreach (var col in input.Split('\n')[i * 2].Trim().Split(' '))
                {
                    arr[j] = int.Parse(col.Trim());
                    j++;
                }
                //Act
                var m = NewYearChaos.MinimumBribes(arr);
                //Assert
                switch (i)
                {
                    case 1:
                        Assert.AreEqual("4", m);
                        break;
                   
                    default:
                        break;
                }
            }



        }
        [Test]
        public void TestCase3()
        {
            //Arrange
            string fileName = "input02.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"Array\Data\NewYearChaos\input\", fileName);
            String input = File.ReadAllText(path);
            int numTasks = int.Parse(input.Split('\n')[0].Trim().Split(' ')[0]);
            for (int i = 1; i <= numTasks; i++)
            {
                int j = 0;
                int arrLength = int.Parse(input.Split('\n')[i * 2 - 1].Trim().Split(' ')[0]);
                int[] arr = new int[arrLength];
                foreach (var col in input.Split('\n')[i * 2].Trim().Split(' '))
                {
                    arr[j] = int.Parse(col.Trim());
                    j++;
                }
                //Act
                var m = NewYearChaos.MinimumBribes(arr);
                //Assert
                switch (i)
                {
                    case 1:
                        Assert.AreEqual("966", m);
                        break;

                    default:
                        break;
                }
            }



        }
    }
}
