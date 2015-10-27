using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathmagician;

namespace MathmagicianTests
{
    [TestClass]
    public class FibonacciNumbersTest
    {
        [TestMethod]
        public void FibonnacoiEnsureICanCreateClassInstance()
        {
            FibonacciNumbers fib = new FibonacciNumbers();
            Assert.IsNotNull(fib);
        }

        [TestMethod]
        public void FibonacciShouldPrintFirstNumber()
        {
            FibonacciNumbers fib = new FibonacciNumbers();
            int expected = 0;
            int actual = fib.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciShouldPrintNextNumber()
        {
            FibonacciNumbers fib = new FibonacciNumbers();
            int input = 0;
            int expected = 1;
            int actual = fib.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciShouldPrintAVariableSequenceOfNumbers()
        {
            FibonacciNumbers fib = new FibonacciNumbers();
            int input = 8;
            int[] expected = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
            int[] actual = fib.GetSequence(input);
            //Collection Assert compares collections 
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciPrintSequencenumbers()
        {
            FibonacciNumbers fib = new FibonacciNumbers();
            int length = 7;
            string expected = "0 1 1 2 3 5 8";
            string actual = fib.ToString(fib.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }
    }
}
