using ConsoleApp472;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestApplication
{
    [TestClass]
    public class UnitTestNegate
    {
        [TestMethod]
        public void TestMethod_Negate_true()
        {
            const bool source = true;
            string expected = string.Empty;
            string result = Program.Negate(source);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestMethod_Negate_false()
        {
            const bool source = false;
            const string expected = " not";
            string result = Program.Negate(source);
            Assert.AreEqual(result, expected);
        }
    }
}