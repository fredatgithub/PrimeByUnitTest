using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp472;

namespace UnitTestApplication
{
    [TestClass]
    public class UnitTestApplication
    {
        [TestMethod]
        public void TestMethod_Prime_0()
        {
            const int source = 0;
            const bool expected = false;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_1()
        {
            const int source = 1;
            const bool expected = false;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_2()
        {
            const int source = 2;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_3()
        {
            const int source = 3;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_4()
        {
            const int source = 4;
            const bool expected = false;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_5()
        {
            const int source = 5;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_6()
        {
            const int source = 6;
            const bool expected = false;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_7()
        {
            const int source = 7;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_9()
        {
            const int source = 9;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_11()
        {
            const int source = 11;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_13()
        {
            const int source = 13;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_15()
        {
            const int source = 15;
            const bool expected = false;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_17()
        {
            const int source = 17;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_19()
        {
            const int source = 19;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethodPrime_23()
        {
            const int source = 23;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethodPrime_29()
        {
            const int source = 29;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }
    }
}