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

            string fileNameOutput = "output00.txt";
            path = Path.Combine(Environment.CurrentDirectory, @"Array\Data\Crush\output\", fileNameOutput);
            String output = File.ReadAllText(path);
            int outputValue = int.Parse(output.Split('\n')[0].Trim());

            int N = int.Parse(input.Split('\n')[0].Trim().Split(' ')[0]);
            int M = int.Parse(input.Split('\n')[0].Trim().Split(' ')[1]);

            int i = 0, j = 0;
            int[][] arr = new int[M][];

            foreach (var row in input.Split('\n'))
            {
                if (i != 0)
                {
                    j = 0;
                    arr[i - 1] = new int[M];
                    foreach (var col in row.Trim().Split(' '))
                    {
                        arr[i - 1][j] = int.Parse(col.Trim());
                        j++;
                    }
                }

                i++;
            }
            //Act
            var result = Crush.crush(N, arr);
            //Assert
            Assert.AreEqual(result, outputValue);
        }
        [Test]
        public void TestCase1()
        {
            //Arrange
            string fileName = "input14.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"Array\Data\Crush\input\", fileName);
            String input = File.ReadAllText(path);

            string fileNameOutput = "output14.txt";
            path = Path.Combine(Environment.CurrentDirectory, @"Array\Data\Crush\output\", fileNameOutput);
            String output = File.ReadAllText(path);
            int outputValue = int.Parse(output.Split('\n')[0].Trim());

            int N = int.Parse(input.Split('\n')[0].Trim().Split(' ')[0]);
            int M = int.Parse(input.Split('\n')[0].Trim().Split(' ')[1]);

            int i = 0, j = 0;
            int[][] arr = new int[M][];

            foreach (var row in input.Split('\n'))
            { 
                if (i != 0)
                {
                    j = 0;
                    arr[i-1] = new int[M];
                    foreach (var col in row.Trim().Split(' '))
                    {
                        arr[i-1][j] = int.Parse(col.Trim());
                        j++;
                    }
                }
               
                i++;
            }
            //Act
            var result = Crush.crush(N, arr);
            //Assert
            Assert.AreEqual(result, outputValue);
        }
        [Test]
        public void TestCase2()
        {
            //Arrange
            string fileName = "input15.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"Array\Data\Crush\input\", fileName);
            String input = File.ReadAllText(path);

            string fileNameOutput = "output15.txt";
            path = Path.Combine(Environment.CurrentDirectory, @"Array\Data\Crush\output\", fileNameOutput);
            String output = File.ReadAllText(path);
            int outputValue = int.Parse(output.Split('\n')[0].Trim());

            int N = int.Parse(input.Split('\n')[0].Trim().Split(' ')[0]);
            int M = int.Parse(input.Split('\n')[0].Trim().Split(' ')[1]);

            int i = 0, j = 0;
            int[][] arr = new int[M][];

            foreach (var row in input.Split('\n'))
            {
                if (i != 0)
                {
                    j = 0;
                    arr[i - 1] = new int[M];
                    foreach (var col in row.Trim().Split(' '))
                    {
                        arr[i - 1][j] = int.Parse(col.Trim());
                        j++;
                    }
                }

                i++;
            }
            //Act
            var result = Crush.crush(N, arr);
            //Assert
            Assert.AreEqual(result, outputValue);
        }
    }
}
