using InterviewPreperationKit.CtCI.BigO;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPreparationKit.Test.CtCI.BigO
{
    public class SearchTest
    {
        [Test]
        public void CheckLinearTrue()
        {
            //Arrange
            int[] arr = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            int x = 80;
            //Assert
            var result = Search.LinearSearch(arr, x);
            //Check
            Assert.AreEqual(7, result);

        }
    }
}
