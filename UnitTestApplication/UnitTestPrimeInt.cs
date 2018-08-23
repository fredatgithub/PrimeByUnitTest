using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp472;

namespace UnitTestApplication
{
    [TestClass]
    public class UnitTestPrimeInt
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
            const bool expected = false;
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
        public void TestMethod_Prime_21()
        {
            const int source = 21;
            const bool expected = false;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_23()
        {
            const int source = 23;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_29()
        {
            const int source = 29;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_31()
        {
            const int source = 31;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_37()
        {
            const int source = 37;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        // testing large numbers
        [TestMethod]
        public void TestMethod_Prime_123()
        {
            const int source = 123;
            const bool expected = false;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_127()
        {
            const int source = 127;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_1234567()
        {
            const int source = 1234567;
            const bool expected = false;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }


        [TestMethod]
        public void TestMethod_Prime_123456789()
        {
            const int source = 123456789;
            const bool expected = false;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_104729()
        {
            const int source = 104729;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_1004729()
        {
            const int source = 1004729;
            const bool expected = false;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_10004729()
        {
            const int source = 10004729;
            const bool expected = false;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_int_max_value()
        {
            const int source = int.MaxValue;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }
    }
}