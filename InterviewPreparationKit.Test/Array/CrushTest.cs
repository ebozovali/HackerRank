using InterviewPreperationKit.ArrayEx;
using NUnit.Framework;
using System;
using System.IO;
using System.Linq;



namespace InterviewPreparationKit.Test.Array
{
    public class CrushTest
    {

        [Test]
        public void TestCase0()
        {
            //Arrange
            string fileName = "input00.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"Array\Data\Crush\input\", fileName);
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
            var result = ArraysLeftRotation.rotLeft(arr,numRotation);

            ////Assert
            Assert.AreEqual(new int[] { 5, 1, 2, 3, 4 }, result);
        }
       
    }
}
