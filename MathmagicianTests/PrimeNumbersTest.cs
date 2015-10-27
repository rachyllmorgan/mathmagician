using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathmagician;

namespace MathmagicianTests
{
    [TestClass]
    public class PrimeNumbersTest
    {
        [TestMethod]
        public void PrimeEnsureICanCreateClassInstance()
        {
            PrimeNumbers prime = new PrimeNumbers();
            Assert.IsNotNull(prime);
        }

        [TestMethod]
        public void PrimeShouldPrintFirstNumber()
        {
            PrimeNumbers prime = new PrimeNumbers();
            int expected = 2;
            int actual = prime.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeShouldPrintNextNumber()
        {
            PrimeNumbers prime = new PrimeNumbers();
            int input = 2;
            int expected = 3;
            int actual = prime.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeShouldPrintAVariableSequenceOfNumbers()
        {
            PrimeNumbers prime = new PrimeNumbers();
            int input = 8;
            int[] expected = new int[] { 2, 3, 5, 7, 11, 13, 17, 19 };
            int[] actual = prime.GetSequence(input);
            //Collection Assert compares collections 
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimePrintSequencenumbers()
        {
            PrimeNumbers prime = new PrimeNumbers();
            int length = 8;
            string expected = "2 3 5 7 11 13 17 19";
            string actual = prime.ToString(prime.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }
    }
}
