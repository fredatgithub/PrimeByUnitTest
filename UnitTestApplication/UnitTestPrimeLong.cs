using ConsoleApp472;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestApplication
{
    [TestClass]
    public class UnitTestPrimeLong
    {
        [TestMethod]
        public void TestMethod_Prime_long_max_value()
        {
            const long source = long.MaxValue;
            const bool expected = false;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_long_1011001110001111()
        {
            const long source = 1011001110001111;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_long_1090109110921093()
        {
            const long source = 1090109110921093;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_long_1111235916285193()
        {
            const long source = 1111235916285193;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_long_100123456789()
        {
            const long source = 100123456789;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        /**
         * 
         *  prime
101111111111 prime
101234567897 prime
101601701401 prime
101740496633 prime
103723971119 prime
105840677923 prime
107928278317 prime
109297270343 prime 
         * */
    }
}