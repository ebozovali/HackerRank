using InterviewPreperationKit.WarmUp;
using NUnit.Framework;
using System;
using System.Linq;

namespace InterviewPreparationKit.Test.WarmUp
{
    public class JumpingOnTheCloudsTest
    {

        [Test]
        public void TestCase0()
        {
            //Arrange
           
            string path = "0 0 1 0 0 1 0";
            var pathArr=path.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            //Act
            var result = JumpingOnTheClouds.JumpingOnClouds(pathArr);
            //Assert
            Assert.AreEqual(4, result);
        }
        [Test]
        public void TestCase1()
        {
            //Arrange
            string path = "0 0 0 1 0 0";
            var pathArr = path.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            //Act
            var result = JumpingOnTheClouds.JumpingOnClouds(pathArr);
            //Assert
            Assert.AreEqual(3, result);
        }
    }
}
