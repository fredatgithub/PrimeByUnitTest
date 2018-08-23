using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp472;

namespace UnitTestApplication
{
    [TestClass]
    public class UnitTestApplication
    {
        [TestMethod]
        public void TestMethodPrime_0()
        {
            const int source = 0;
            const bool expected = false;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethodPrime_1()
        {
            const int source = 1;
            const bool expected = false;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethodPrime_2()
        {
            const int source = 2;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethodPrime_3()
        {
            const int source = 3;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethodPrime_4()
        {
            const int source = 4;
            const bool expected = false;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethodPrime_5()
        {
            const int source = 5;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethodPrime_6()
        {
            const int source = 6;
            const bool expected = false;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethodPrime_7()
        {
            const int source = 7;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethodPrime_9()
        {
            const int source = 9;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethodPrime_11()
        {
            const int source = 11;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethodPrime_13()
        {
            const int source = 13;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethodPrime_15()
        {
            const int source = 15;
            const bool expected = false;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethodPrime_17()
        {
            const int source = 17;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethodPrime_19()
        {
            const int source = 19;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }
    }
}