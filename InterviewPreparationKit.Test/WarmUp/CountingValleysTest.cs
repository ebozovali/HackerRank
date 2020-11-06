using InterviewPreperationKit.WarmUp;
using NUnit.Framework;


namespace InterviewPreparationKit.Test.WarmUp
{
    public class CountingValleysTest
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void TestCase0()
        {
            //Arrange
            int steps = 8;
            string path = "UDDDUDUU";
            //Act
            var result = CountingValleys.CountingValleys(steps, path);
            //Assert
            Assert.AreEqual(1, result);
        }
        [Test]
        public void TestCase1()
        {
            //Arrange
            int steps = 12;
            string path = "DDUUDDUDUUUD";
            //Act
            var result = CountingValleys.CountingValleys(steps, path);
            //Assert
            Assert.AreEqual(2, result);
        }
    }
}
