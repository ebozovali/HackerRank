using InterviewPreperationKit.ArrayEx;
using InterviewPreperationKit.DictionariesAndHashmaps;
using NUnit.Framework;
using System;
using System.IO;
using System.Linq;



namespace InterviewPreparationKit.Test.DictionariesAndHashmaps
{
    public class RansomNoteTest
    {

        [Test]
        public void TestCase0()
        {
            //Arrange
            string fileName = "input00.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"DictionariesAndHashmaps\Data\RansomNote\input\", fileName);
            String input = File.ReadAllText(path);
            var inputRows = input.Split('\n');
            int magazineLength = int.Parse(inputRows[0].Trim().Split(' ')[0]);
            int noteLength= int.Parse(inputRows[0].Trim().Split(' ')[1]);
            string[] magazine = inputRows[1].Split(' ');
            string[] ransomNote = inputRows[2].Split(' ');

            string fileNameOutput = "output00.txt";
            path = Path.Combine(Environment.CurrentDirectory, @"DictionariesAndHashmaps\Data\RansomNote\output\", fileNameOutput);
            String output = File.ReadAllText(path);

           
            //Act
            var result = RansomNote.CheckMagazine(magazine, ransomNote);
            //Assert
            Assert.AreEqual(result, output);
        }

        [Test]
        public void TestCase1()
        {
            //Arrange
            string fileName = "input20.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"DictionariesAndHashmaps\Data\RansomNote\input\", fileName);
            String input = File.ReadAllText(path);
            var inputRows = input.Split('\n');
            int magazineLength = int.Parse(inputRows[0].Trim().Split(' ')[0]);
            int noteLength = int.Parse(inputRows[0].Trim().Split(' ')[1]);
            string[] magazine = inputRows[1].Split(' ');
            string[] ransomNote = inputRows[2].Split(' ');

            string fileNameOutput = "output20.txt";
            path = Path.Combine(Environment.CurrentDirectory, @"DictionariesAndHashmaps\Data\RansomNote\output\", fileNameOutput);
            String output = File.ReadAllText(path);


            //Act
            var result = RansomNote.CheckMagazine(magazine, ransomNote);
            //Assert
            Assert.AreEqual(result, output);
        }
        [Test]
        public void TestCase2()
        {
            //Arrange
            string fileName = "input21.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"DictionariesAndHashmaps\Data\RansomNote\input\", fileName);
            String input = File.ReadAllText(path);
            var inputRows = input.Split('\n');
            int magazineLength = int.Parse(inputRows[0].Trim().Split(' ')[0]);
            int noteLength = int.Parse(inputRows[0].Trim().Split(' ')[1]);
            string[] magazine = inputRows[1].Split(' ');
            string[] ransomNote = inputRows[2].Split(' ');

            string fileNameOutput = "output21.txt";
            path = Path.Combine(Environment.CurrentDirectory, @"DictionariesAndHashmaps\Data\RansomNote\output\", fileNameOutput);
            String output = File.ReadAllText(path);


            //Act
            var result = RansomNote.CheckMagazine(magazine, ransomNote);
            //Assert
            Assert.AreEqual(result, output);
        }
        [Test]
        public void TestCase3()
        {
            //Arrange
            string fileName = "input09.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"DictionariesAndHashmaps\Data\RansomNote\input\", fileName);
            String input = File.ReadAllText(path);
            var inputRows = input.Split('\n');
            int magazineLength = int.Parse(inputRows[0].Trim().Split(' ')[0]);
            int noteLength = int.Parse(inputRows[0].Trim().Split(' ')[1]);
            string[] magazine = inputRows[1].Split(' ');
            string[] ransomNote = inputRows[2].Split(' ');

            string fileNameOutput = "output09.txt";
            path = Path.Combine(Environment.CurrentDirectory, @"DictionariesAndHashmaps\Data\RansomNote\output\", fileNameOutput);
            String output = File.ReadAllText(path);


            //Act
            var result = RansomNote.CheckMagazine(magazine, ransomNote);
            //Assert
            Assert.AreEqual(result, output);
        }
    }
}
