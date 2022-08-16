
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LINQToObject;

namespace LINQToObjectTesting
{
    [TestClass]
    public class Testing
    {
        [TestMethod]
        public void FirstPositiveLastNegative()
        {
            int[] sequency = { -1, 2, 0, 1, 1, -2, -5, 9 };
            Assert.AreEqual("2, -5", sequency.FirstPositiveLastNegative());
        }
        [TestMethod]
        public void FirstPositiveInSequency()
        {
            int[] sequency = { -18, 28, 10, 1, 1, -29, -5, 9 };
            Assert.AreEqual(28, sequency.FirstPositiveInSequency(8));
        }
        [TestMethod]
        public void LastRowOfSequency()
        {
            string[] sequency = { "1erwe,", "urtuhh,", "2dfhw", "4trt1", "fswws" };
            Assert.AreEqual("4trt1", sequency.LastRowOfSequency(5));
        }
        [TestMethod]
        public void PositiveSequency()
        {
            int[] sequency = { -18, 28, 10, 1, 1, -29, -5, 9 };
            Assert.AreEqual (4, sequency.PositiveSequency().Count());
        }
    }
}