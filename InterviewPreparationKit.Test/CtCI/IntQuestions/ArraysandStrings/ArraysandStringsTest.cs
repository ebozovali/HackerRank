using InterviewPreperationKit.CtCI.IntQuestions.ArraysandStrings;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPreparationKit.Test.CtCI.IntQuestions.ArraysandStringsTest
{
    public class ArraysandStringsTest
    {
        #region IsUnique
      
        #region data structures
        [Test]
        public void IsUniqueCharsBitvectorTrue()
        {
            //Arrange
            string word = "asdefg";
            //Assert
            var result = ArraysandStrings.IsUniqueCharsBitvector(word);
            //Check
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsUniqueCharsBitvectorFalse()
        {
            //Arrange
            string word = "asdefgg";
            //Assert
            var result = ArraysandStrings.IsUniqueCharsBitvector(word);
            //Check
            Assert.AreEqual(false, result);
        }

        [Test]
        public void IsUniqueCharsHashsetTrue()
        {
            //Arrange
            string word = "asdefg";
            //Assert
            var result = ArraysandStrings.IsUniqueCharsHashset(word);
            //Check
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsUniqueCharsHashsetFalse()
        {
            //Arrange
            string word = "asdefgg";
            //Assert
            var result = ArraysandStrings.IsUniqueCharsHashset(word);
            //Check
            Assert.AreEqual(false, result);
        }
        #endregion
        #region Without data structures
        [Test]
        public void IsUniqueBruteForceTrue()
        {
            //Arrange
            string word = "asdefg";
            //Assert
            var result = ArraysandStrings.IsUniqueBruteForce(word);
            //Check
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsUniqueBruteForceFalse()
        {
            //Arrange
            string word = "asdefgg";
            //Assert
            var result = ArraysandStrings.IsUniqueBruteForce(word);
            //Check
            Assert.AreEqual(false, result);
        }

        [Test]
        public void IsUniqueSortTrue()
        {
            //Arrange
            string word = "asdefg";
            //Assert
            var result = ArraysandStrings.IsUniqueSort(word);
            //Check
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsUniqueSortFalse()
        {
            //Arrange
            string word = "asdefgg";
            //Assert
            var result = ArraysandStrings.IsUniqueSort(word);
            //Check
            Assert.AreEqual(false, result);
        }
        #endregion

        #endregion
        #region Permutation

        [Test]
        public void IsPermutationBruteForceTrue()
        {
            //Arrange
            bool expectedResult = true;
            //Assert
            var result = ArraysandStrings.IsPermutationBruteForce("abc","cba");
            //Check
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void IsPermutationBruteForceFalse()
        {
            //Arrange
            bool expectedResult = false;
            //Assert
            var result = ArraysandStrings.IsPermutationBruteForce("aaaa", "abcd");
            //Check
            Assert.AreEqual(expectedResult, result);
        }

        #region Hashset
        [Test]
        public void IsPermutationHashSetTrue()
        {
            //Arrange
            bool expectedResult = true;
            //Assert
            var result = ArraysandStrings.IsPermutationHashSet("addbcd", "cdddba");
            //Check
            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void IsPermutationHashSetFalse()
        {
            //Arrange
            bool expectedResult = false;
            //Assert
            var result = ArraysandStrings.IsPermutationHashSet("aaaa", "abcd");
            //Check
            Assert.AreEqual(expectedResult, result);
        }
        #endregion
        #region Array
        [Test]
        public void IsPermutationArrayTrue()
        {
            //Arrange
            bool expectedResult = true;
            //Assert
            var result = ArraysandStrings.IsPermutationArray("addbcd", "cdddba");
            //Check
            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void IsPermutationArrayFalse()
        {
            //Arrange
            bool expectedResult = false;
            //Assert
            var result = ArraysandStrings.IsPermutationArray("aaaa", "abcd");
            //Check
            Assert.AreEqual(expectedResult, result);
        }
        #endregion

        #endregion


    }
}
