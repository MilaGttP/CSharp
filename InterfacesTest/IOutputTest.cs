
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interfaces;

namespace InterfacesTest
{
    [TestClass]
    public class IOutput2
    {
        [TestMethod]
        public void ShowEvenReturn24()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Array arr = new Array(array);
            string expected = "24";
            Assert.AreEqual(expected, arr.ShowEven());
        }
        [TestMethod]
        public void ShowOddReturn135()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Array arr = new Array(array);
            string expected = "135";
            Assert.AreEqual(expected, arr.ShowOdd());
        }
    }
}