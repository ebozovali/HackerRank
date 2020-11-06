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
            int i = 0;

            string fileNameOutput = "output00.txt";
            path = Path.Combine(Environment.CurrentDirectory, @"Array\Data\MinimumSwaps2\output\", fileNameOutput);
            String output = File.ReadAllText(path);
            int outputValue = int.Parse(output.Split('\n')[0].Trim());

            int arrLength = int.Parse(input.Split('\n')[0].Trim());
            int[] arr = new int[arrLength];
            foreach (var col in input.Split('\n')[1].Trim().Split(' '))
            {
                arr[i] = int.Parse(col.Trim());
                i++;
            }
            //Act
            var result = MinimumSwaps2.MinimumSwaps(arr);

            ////Assert
            Assert.AreEqual(outputValue, result);
        }
        [Test]
        public void TestCase1()
        {
            //Arrange
            string fileName = "input01.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"Array\Data\MinimumSwaps2\input\", fileName);
            String input = File.ReadAllText(path);
            int i = 0;

            string fileNameOutput = "output01.txt";
            path = Path.Combine(Environment.CurrentDirectory, @"Array\Data\MinimumSwaps2\output\", fileNameOutput);
            String output = File.ReadAllText(path);
            int outputValue = int.Parse(output.Split('\n')[0].Trim());

            int arrLength = int.Parse(input.Split('\n')[0].Trim());
            int[] arr = new int[arrLength];
            foreach (var col in input.Split('\n')[1].Trim().Split(' '))
            {
                arr[i] = int.Parse(col.Trim());
                i++;
            }
            //Act
            var result = MinimumSwaps2.MinimumSwaps(arr);

            ////Assert
            Assert.AreEqual(outputValue, result);
        }
        [Test]
        public void TestCase2()
        {
            //Arrange
            string fileName = "input02.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"Array\Data\MinimumSwaps2\input\", fileName);
            String input = File.ReadAllText(path);
            int i = 0;

            string fileNameOutput = "output02.txt";
            path = Path.Combine(Environment.CurrentDirectory, @"Array\Data\MinimumSwaps2\output\", fileNameOutput);
            String output = File.ReadAllText(path);
            int outputValue = int.Parse(output.Split('\n')[0].Trim());

            int arrLength = int.Parse(input.Split('\n')[0].Trim());
            int[] arr = new int[arrLength];
            foreach (var col in input.Split('\n')[1].Trim().Split(' '))
            {
                arr[i] = int.Parse(col.Trim());
                i++;
            }
            //Act
            var result = MinimumSwaps2.MinimumSwaps(arr);

            ////Assert
            Assert.AreEqual(outputValue, result);
        }
        [Test]
        public void TestCase3()
        {
            //Arrange
            string fileName = "input09.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"Array\Data\MinimumSwaps2\input\", fileName);
            String input = File.ReadAllText(path);
            int i = 0;

            string fileNameOutput = "output09.txt";
            path = Path.Combine(Environment.CurrentDirectory, @"Array\Data\MinimumSwaps2\output\", fileNameOutput);
            String output = File.ReadAllText(path);
            int outputValue = int.Parse(output.Split('\n')[0].Trim());

            int arrLength = int.Parse(input.Split('\n')[0].Trim());
            int[] arr = new int[arrLength];
            foreach (var col in input.Split('\n')[1].Trim().Split(' '))
            {
                arr[i] = int.Parse(col.Trim());
                i++;
            }
            //Act
            var result = MinimumSwaps2.MinimumSwaps(arr);

            ////Assert
            Assert.AreEqual(outputValue, result);
        }
    }
}
