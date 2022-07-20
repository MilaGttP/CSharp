
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace DelegatesAndEventsTests
{
    using DelegatesAndEvents;

    [TestClass]
    public class ArrayTesting
    {
        [TestMethod]
        public void GetEven_Return24()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Array arr = new Array(array);
            ArrayDelegate <string> getEvenDelegate = (ArrayDelegate<string>)arr.GetEven();
            Assert.AreEqual("24", getEvenDelegate);
        }
    }
}