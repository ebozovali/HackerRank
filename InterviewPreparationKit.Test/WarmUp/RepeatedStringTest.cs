using InterviewPreperationKit.WarmUp;
using NUnit.Framework;
using System;
using System.Linq;

namespace InterviewPreparationKit.Test.WarmUp
{
    public class RepeatedStringTest
    {

        [Test]
        public void TestCase0()
        {
            //Arrange
            long numberOfChars = 10;
            string s = "aba";
            //Act
            var result = RepeatedString.repeatedString(s,numberOfChars);
            //Assert
            Assert.AreEqual(7, result);
        }
        [Test]
        public void TestCase1()
        {
            //Arrange
            long numberOfChars = 1000000000000;
            string s = "a";
            //Act
            var result = RepeatedString.repeatedString(s, numberOfChars);
            //Assert
            Assert.AreEqual(1000000000000, result);
        }
    }
}
