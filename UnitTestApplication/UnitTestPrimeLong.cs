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
    }
}