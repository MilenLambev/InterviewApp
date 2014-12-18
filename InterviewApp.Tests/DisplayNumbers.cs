using System;
using InterviewApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewApp.Tests
{
    [TestClass]
    public class DisplayNumbersTest
    {
        [TestMethod]
        public void ValidateRequestWithProperParametersWors()
        {
            DisplayNumbers displayNumbers = new DisplayNumbers();
            displayNumbers.DisplayNumbersInRange(1, 100);
        }

        [TestMethod]
        public void ValidateResponseNotEmpty()
        {
            DisplayNumbers displayNumbers = new DisplayNumbers();
            string result = displayNumbers.DisplayNumbersInRange(1, 100);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ValidateResponseContainsBuzz()
        {
            DisplayNumbers displayNumbers = new DisplayNumbers();
            string result = displayNumbers.DisplayNumbersInRange(1, 100);

            Assert.IsTrue(result.Contains("buzz"));
        }

        [TestMethod]
        public void ValidateFizzAndBuzzAllignedProperly()
        {
            DisplayNumbers displayNumbers = new DisplayNumbers();
            string result = displayNumbers.DisplayNumbersInRange(15, 15);

            Assert.IsTrue(result.Contains("fizz buzz"));
        }

        [TestMethod]
        public void ValidateNegativeRangeWorksProperly()
        {
            DisplayNumbers displayNumbers = new DisplayNumbers();
            string result = displayNumbers.DisplayNumbersInRange(-601, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidParametersTest()
        {
            DisplayNumbers displayNumbers = new DisplayNumbers();
            string result = displayNumbers.DisplayNumbersInRange(100, 99);
        }
    }
}
