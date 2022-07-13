
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OperatorOverload;

namespace OperOverloadingTests
{
    [TestClass]
    public class ShopTesting
    {
        [TestMethod]
        public void Add_180And20Return200()
        {
            int expected = 200;
            Shop shop = new Shop(180);
            double actual = shop.Area + 20;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sub_180Minus10Return170()
        {
            int expected = 170;
            Magazine magazine = new Magazine(180);
            int actual = magazine.WorkerQuantity - 10;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Equal_ReturnTrue()
        {
            Shop shop = new Shop(120);
            Shop otherShop = new Shop(120);
            bool actual = shop == otherShop;
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void IsntEqual_ReturnTrue()
        {
            Shop shop = new Shop(150);
            Shop otherShop = new Shop(120);
            bool actual = shop != otherShop;
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void FirstMoreThanSecond_ReturnTrue()
        {
            Shop shop = new Shop(150);
            Shop otherShop = new Shop(120);
            bool actual = shop > otherShop;
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void FirstLessThanSecond_ReturnTrue()
        {
            Shop shop = new Shop(120);
            Shop otherShop = new Shop(150);
            bool actual = shop < otherShop;
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void Equals_ReturnTrue()
        {
            Shop shop = new Shop(190);
            Shop otherShop = new Shop(190);
            bool actual = shop.Equals(otherShop);
            Assert.IsTrue(actual);
        }
    }
}