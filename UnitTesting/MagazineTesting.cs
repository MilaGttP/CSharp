
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OperatorOverload;

namespace OperOverloadingTests
{
    [TestClass]
    public class MagazineTesting
    {
        [TestMethod]
        public void Add_12And8Return20()
        {
            int expected = 20;
            Magazine magazine = new Magazine(12);
            int actual = magazine.WorkerQuantity + 8;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sub_12Minus2Return10()
        {
            int expected = 10;
            Magazine magazine = new Magazine(12);
            int actual = magazine.WorkerQuantity - 2;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Equal_ReturnTrue()
        {
            Magazine magazine = new Magazine(12);
            Magazine otherMagazine = new Magazine(12);
            bool actual = magazine == otherMagazine;
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void IsntEqual_ReturnTrue()
        {
            Magazine magazine = new Magazine(15);
            Magazine otherMagazine = new Magazine(12);
            bool actual = magazine != otherMagazine;
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void FirstMoreThanSecond_ReturnTrue()
        {
            Magazine magazine = new Magazine(15);
            Magazine otherMagazine = new Magazine(12);
            bool actual = magazine > otherMagazine;
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void FirstLessThanSecond_ReturnTrue()
        {
            Magazine magazine = new Magazine(10);
            Magazine otherMagazine = new Magazine(12);
            bool actual = magazine < otherMagazine;
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void Equals_ReturnTrue()
        {
            Magazine magazine = new Magazine(12);
            Magazine otherMagazine = new Magazine(12);
            bool actual = magazine.Equals(otherMagazine);
            Assert.IsTrue(actual);
        }
    }
}