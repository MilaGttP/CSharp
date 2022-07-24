
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DelegatesAndEvents;

namespace DelegatesAndEventsTests
{
    [TestClass]
    public class ShapesTesting
    {
        [TestMethod]
        public void GetTriangleSquare_Return10()
        {
            int side = 2, height = 10;
            Shape triangle = new Shape();
            ShapeDelegate getTriangleDelegate = new ShapeDelegate (triangle.GetTriangleSquare);
            Assert.AreEqual(10, getTriangleDelegate(side, height));
        }
        [TestMethod]
        public void GetRectangleSquare_Return20()
        {
            int width = 2, length = 10;
            Shape rectangle = new Shape();
            ShapeDelegate getRectangleDelegate = new ShapeDelegate(rectangle.GetRectangleSquare);
            Assert.AreEqual(20, getRectangleDelegate(width, length));
        }
    }
}
