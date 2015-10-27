using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathmagician;


namespace MathmagicianTests
{
    [TestClass]
    public class NaturalNumbersTest
    {
        //Naming convention will seem like phrases
        //  Descriptive and tell what you are testing
        //  Names must all be unique

        [TestMethod]
        public void EnsureICanCreateClassInstance()
        {
            NaturalNumbers nats = new NaturalNumbers();  // <---- Every test has a setup
            // Assert class verifies true/false
            Assert.IsNotNull(nats);     // <----- And then an Assert
        }

        [TestMethod]
        public void ShouldPrintFirstNumber()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int expected = 1;
            int actual = nats.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        /*
        [TestMethod]
        [ExpectedException(typeof(AccessViolationException))]  //creating a test for a known failure
        public void NoOneCanAccessPrivateDataMember()
        {
            NaturalNumbers nats = new NaturalNumbers();
            //nats.first;                  ***** Won't compile because of private access
        }
        */

        [TestMethod]
        public void ShouldPrintNextNumber()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int input = 1;
            int expected = 2;
            int actual = nats.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldPrintNextNumber3()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int input = 3;
            int expected = 4;
            int actual = nats.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldPrintSequenceOfNumbers()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] actual = nats.GetSequence();
            //Collection Assert compares collections 
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldPrintAVariableSequenceOfNumbers()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int input = 8;
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] actual = nats.GetSequence(input);
            //Collection Assert compares collections 
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldProvideSameSequences()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int input = 10;
            int[] sequencewithlength = nats.GetSequence(input);
            int[] sequencenolength = nats.GetSequence();
            CollectionAssert.AreEqual(sequencenolength, sequencewithlength);
        }

        [TestMethod]
        public void PrintSequencenumbers()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int length = 7;
            string expected = "1 2 3 4 5 6 7";
            string actual = nats.ToString(nats.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }
    }
}
