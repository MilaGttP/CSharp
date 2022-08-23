
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnonMethodsAndLambda;

namespace AnonimousAndLambdaTesting
{
    [TestClass]
    public class ConvertColorTesting
    {
        [TestMethod]
        public void ConvertColor()
        {
            Dispacher dispacher = new Dispacher();
            dispacher.colorEvent += delegate (System.Drawing.Color color) { return $"{color.R}, {color.G}, {color.B}"; };
            Assert.AreEqual("255, 0, 0", dispacher.ConvertColor(System.Drawing.Color.Red));
        }
    }
}
