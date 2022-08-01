
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtensionMethods;

namespace ExtensionMethodsTesting
{
    [TestClass]
    public class ExtensionsTesting
    {
        [TestMethod]
        public void IsFibonacciTest()
        {
            Assert.IsTrue(13.IsFibonacci());
        }
        [TestMethod]
        public void WordsQuantityTest()
        {
            Assert.AreEqual(4, "Hello everybody in world!".WordsQuantity());
        }
        [TestMethod]
        public void LastWordLengthTest()
        {
            Assert.AreEqual(6, "Hello world!".LastWordLength());
        }
        [TestMethod]
        public void IsValidStringTest()
        {
            Assert.IsTrue("(())".IsValidString());
            Assert.IsFalse("[[{]}]".IsValidString());
        }
        [TestMethod]
        public void FilterArrayTest()
        {
            Assert.AreEqual("121", "12618876".FilterArray("6887"));
        }
    }
}