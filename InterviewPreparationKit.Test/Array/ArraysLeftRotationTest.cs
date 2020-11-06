using InterviewPreperationKit.ArrayEx;
using NUnit.Framework;
using System;
using System.IO;
using System.Linq;



namespace InterviewPreparationKit.Test.Array
{
    public class ArraysLeftRotationTest
    {

        [Test]
        public void TestCase0()
        {
            //Arrange
            string fileName = "input00.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"Array\Data\ArraysLeftRotation\input\", fileName);
            String input = File.ReadAllText(path);
            int i = 0;

            int arrLength = int.Parse(input.Split('\n')[0].Trim().Split(' ')[0]);
            int numRotation = int.Parse(input.Split('\n')[0].Trim().Split(' ')[1]);

            int[] arr = new int[arrLength];
            foreach (var col in input.Split('\n')[1].Trim().Split(' '))
            {
                arr[i] = int.Parse(col.Trim());
                i++;
            }
            //Act
            var result = RansomNote.RotLeft(arr,numRotation);

            ////Assert
            Assert.AreEqual(new int[] { 5, 1, 2, 3, 4 }, result);
        }
        [Test]
        public void TestCase01()
        {
            //Arrange
            string fileName = "input01.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"Array\Data\ArraysLeftRotation\input\", fileName);
            String input = File.ReadAllText(path);
            int i = 0;

            int arrLength = int.Parse(input.Split('\n')[0].Trim().Split(' ')[0]);
            int numRotation = int.Parse(input.Split('\n')[0].Trim().Split(' ')[1]);

            int[] arr = new int[arrLength];
            foreach (var col in input.Split('\n')[1].Trim().Split(' '))
            {
                arr[i] = int.Parse(col.Trim());
                i++;
            }
            //Act
            var result = RansomNote.RotLeft(arr, numRotation);

            ////Assert
            Assert.AreEqual(new int[] { 77, 97 ,58 ,1 ,86 ,58 ,26 ,10 ,86 ,51 ,41 ,73 ,89 ,7 ,10 ,1 ,59 ,58 ,84 ,77 }, result);
        }
        [Test]
        public void TestCase10()
        {
            //Arrange
            string fileName = "input10.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"Array\Data\ArraysLeftRotation\input\", fileName);
            String input = File.ReadAllText(path);
            int i = 0;

            int arrLength = int.Parse(input.Split('\n')[0].Trim().Split(' ')[0]);
            int numRotation = int.Parse(input.Split('\n')[0].Trim().Split(' ')[1]);

            int[] arr = new int[arrLength];
            foreach (var col in input.Split('\n')[1].Trim().Split(' '))
            {
                arr[i] = int.Parse(col.Trim());
                i++;
            }
            //Act
            var result = RansomNote.RotLeft(arr, numRotation);

            ////Assert
            Assert.AreEqual(new int[] { 87 ,97 ,33 ,47 ,70 ,37 ,8, 53 ,13 ,93 ,71 ,72 ,51 ,100 ,60 }, result);
        }
    }
}
