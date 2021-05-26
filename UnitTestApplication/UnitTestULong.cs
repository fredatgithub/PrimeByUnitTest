using ConsoleApp472;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestApplication
{
    [TestClass]
    public class UnitTestULong
    {
        [TestMethod]
        public void TestMethod_Prime_Ulong_max_value()
        {
            const ulong source = ulong.MaxValue;
            const bool expected = false;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_Ulong_3_times_int_max_value()
        {
            const ulong source = (ulong)int.MaxValue * 3;
            const bool expected = false;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_Ulong_7_times_int_max_value()
        {
            const ulong source = (ulong)int.MaxValue * 7;
            const bool expected = false;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Prime_long_1000000000100011()
        {
            const ulong source = 1000000000100011;
            const bool expected = true;
            bool result = Program.IsPrime(source);
            Assert.AreEqual(result, expected);
        }
    }
}