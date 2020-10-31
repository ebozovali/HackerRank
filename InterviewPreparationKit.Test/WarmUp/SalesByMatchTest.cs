using InterviewPreperationKit.WarmUp;
using NUnit.Framework;


namespace InterviewPreparationKit.Test.WarmUp
{
    public class SalesByMatchTest
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void TestCase8()
        {
            //Arrange
            int arrayLength = 10;
            int[] arr = new int[10] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };
            //Act
            var result = SalesByMatch.sockMerchant(arrayLength, arr);
            //Assert
            Assert.AreEqual(4, result) ;
        }
        [Test]
        public void TestCase0()
        {
            //Arrange
            int arrayLength = 19;
            int[] arr = new int[9] { 10 ,20, 20, 10, 10, 30, 50, 10, 20 };
            //Act
            var result = SalesByMatch.sockMerchant(arrayLength, arr);
            //Assert
            Assert.AreEqual(3, result);
        }
    }
}
