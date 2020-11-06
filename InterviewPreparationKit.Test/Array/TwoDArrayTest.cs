using InterviewPreperationKit.ArrayEx;
using NUnit.Framework;
using System;
using System.IO;
using System.Linq;



namespace InterviewPreparationKit.Test.Array
{
    public class TwoDArrayTest
    {

        [Test]
        public void TestCase0()
        {
            //Arrange
            string fileName = "input00.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"Array\Data\TwoDArrayTest\input\", fileName);
            String input = File.ReadAllText(path);
            int i = 0, j = 0;
            int[][] arr = new int[6][];

            foreach (var row in input.Split('\n'))
            {
                j = 0;
                arr[i] = new int[6];
                foreach (var col in row.Trim().Split(' '))
                {
                    arr[i][j] = int.Parse(col.Trim());
                    j++;
                }
                i++;
            }
            //Act
            int result = TwoDArray.HourglassSum(arr);
            ////Assert
            Assert.AreEqual(19, result);
         }
        [Test]
        public void TestCase1()
        {
            //Arrange
            string fileName = "input01.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"Array\Data\TwoDArrayTest\input\", fileName);
            String input = File.ReadAllText(path);
            int i = 0, j = 0;
            int[][] arr = new int[6][];

            foreach (var row in input.Split('\n'))
            {
                j = 0;
                arr[i] = new int[6];
                foreach (var col in row.Trim().Split(' '))
                {
                    arr[i][j] = int.Parse(col.Trim());
                    j++;
                }
                i++;
            }
            //Act
            int result = TwoDArray.HourglassSum(arr);
            ////Assert
            Assert.AreEqual(13, result);
        }
        [Test]
        public void TestCase8()
        {
            //Arrange
            string fileName = "input08.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"Array\Data\TwoDArrayTest\input\", fileName);
            String input = File.ReadAllText(path);
            int i = 0, j = 0;
            int[][] arr = new int[6][];
            foreach (var row in input.Split('\n'))
            {
                j = 0;
                arr[i] = new int[6];
                foreach (var col in row.Trim().Split(' '))
                {
                    arr[i][j] = int.Parse(col.Trim());
                    j++;
                }
                i++;
            }
            //Act
            int result = TwoDArray.HourglassSum(arr);
            ////Assert
            Assert.AreEqual(28, result);
        }
        [Test]
        public void TestCase3()
        {
            //Arrange
            string fileName = "input03.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"Array\Data\TwoDArrayTest\input\", fileName);
            String input = File.ReadAllText(path);
            int i = 0, j = 0;
            int[][] arr = new int[6][];
            foreach (var row in input.Split('\n'))
            {
                j = 0;
                arr[i] = new int[6];
                foreach (var col in row.Trim().Split(' '))
                {
                    arr[i][j] = int.Parse(col.Trim());
                    j++;
                }
                i++;
            }
            //Act
            int result = TwoDArray.HourglassSum(arr);
            ////Assert
            Assert.AreEqual(-6, result);
        }
    }
}
