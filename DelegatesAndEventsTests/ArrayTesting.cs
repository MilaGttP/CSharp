
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DelegatesAndEvents;

namespace DelegatesAndEventsTests
{
    [TestClass]
    public class ArrayTesting
    {
        [TestMethod]
        public void GetEven_Return24()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Array arr = new Array(array);
            ArrayDelegate getEvenDelegate = new ArrayDelegate(arr.GetEven);
            Assert.AreEqual("24", getEvenDelegate());
        }
        [TestMethod]
        public void GetOdd_Return135()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Array arr = new Array(array);
            ArrayDelegate getOddDelegate = new ArrayDelegate(arr.GetOdd);
            Assert.AreEqual("135", getOddDelegate());
        }
        [TestMethod]
        public void GetSimpleNumbers_Return2357()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            Array arr = new Array(array);
            ArrayDelegate getSimpleNumbersDelegate = new ArrayDelegate(arr.GetPrimeNumbers);
            Assert.AreEqual("2357", getSimpleNumbersDelegate());
        }
        [TestMethod]
        public void GetFibonacci_Return2357()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            Array arr = new Array(array);
            ArrayDelegate getFibonacciDelegate = new ArrayDelegate(arr.GetFibonacci);
            Assert.AreEqual("012358", getFibonacciDelegate());
        }
    }
}