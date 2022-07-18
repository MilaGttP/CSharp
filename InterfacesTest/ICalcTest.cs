
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interfaces;

namespace InterfacesTest
{
    [TestClass]
    public class ICalc
    {
        [TestMethod]
        public void Less5return4()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Array arr = new Array(array);
            Assert.AreEqual(4, arr.Less(5));
        }
        [TestMethod]
        public void Greater2return3()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Array arr = new Array(array);
            Assert.AreEqual(3, arr.Greater(2));
        }
        [TestMethod]
        public void CountDistinctReturn3()
        {
            int[] array = new int[] { 1, 1, 3, 4, 5 };
            Array arr = new Array(array);
            Assert.AreEqual(3, arr.CountDistinct());
        }
        [TestMethod]
        public void EqualToValueReturn4()
        {
            int[] array = new int[] { 1, 1, 1, 1, 5 };
            Array arr = new Array(array);
            Assert.AreEqual(4, arr.EqualToValue(1));
        }
    }
}