using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPlus()
        {
            Number number = new Number("45", 10) + new Number("1001", 2);
            Assert.AreEqual("54", number.Num);
        }
        [TestMethod]
        public void TestMulti()
        {
            Number number = new Number("365", 8) * new Number("33", 16);
            Assert.AreEqual("12495", number.Num);
        }
        [TestMethod]
        public void TestEqually()
        {
            Assert.AreEqual(true, new Number("3724", 8) == new Number("7D4", 16));
        }
        [TestMethod]
        public void TestMinus()
        {
            Number number = new Number("54878", 10) - new Number("101010", 2);
            Assert.AreEqual("54836", number.Num);
        }
    }
}
