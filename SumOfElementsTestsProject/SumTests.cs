using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfElements;

namespace SumOfElementsTestsProject
{
    [TestClass]
    public class SumTests
    {
        [TestMethod]
        public void CountSumOfElements_SumOfOneTwoThree_IntSix()
        {
            int[] array = { 1, 2, 3 };
            int result = 1 + 2 + 3;

            int actualResult = Sum.CountSumOfElements(array);

            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void CountSumOfElements_SumOfMinusOneMinusTwoMinusThree_IntMinusSix()
        {
            int[] array = { -1, -2, -3 };
            int result = -1 - 2 - 3;

            int actualResult = Sum.CountSumOfElements(array);

            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]

        public void CountSumOfElements_SumOfMinusOneTwoMinusThree_IntMinusTwo()
        {
            int[] array = { -1, 2, -3 };
            int result = -1 + 2 - 3;

            int actualResult = Sum.CountSumOfElements(array);

            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void CountSumOfElements_SumOfZeros_IntZero()
        {
            int[] array = { 0, 0, 0 };
            int result = 0;

            int actualResult = Sum.CountSumOfElements(array);

            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CountSumOfElements_SumOfNull_ArgumentNullException()
        {
            Sum.CountSumOfElements(null);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void CountSumOfElements_SumOfMaxIntAnd1_OverflowException()
        {
           Sum.CountSumOfElements(new [] { int.MaxValue, 1});
        }

    }
}
