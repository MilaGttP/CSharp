using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnonMethodsAndLambda;

namespace AnonimousAndLambdaTesting
{
    [TestClass]
    public class LambdaExpressionsTesting
    {
        [TestMethod]
        public void MultipleofSeven()
        {
            int[] arr = new int[] { 7, 8, 14, 5, 9, 1, 21 };
            LambdaExpressions lambdaExpressions = new LambdaExpressions();  
            Assert.AreEqual(3, lambdaExpressions.MultipleOfSeven(arr));
        }
        [TestMethod]
        public void PositiveInArr()
        {
            int[] arr = new int[] { -7, 8, -14, 5, -9, 1, 21 };
            LambdaExpressions lambdaExpressions = new LambdaExpressions();
            Assert.AreEqual(4, lambdaExpressions.PositiveInArr(arr));
        }
        [TestMethod]
        public void NegativeInArr()
        {
            int[] arr = new int[] { -7, -8, -14, 5, -9, 1, -21 };
            LambdaExpressions lambdaExpressions = new LambdaExpressions();
            Assert.AreEqual(5, lambdaExpressions.NegativeInArr(arr));
        }
        [TestMethod]
        public void FindWord()
        {
            string[] text = { "Hello", "everybody", "in", "room" };
            LambdaExpressions lambdaExpressions = new LambdaExpressions();
            Assert.AreEqual(true, lambdaExpressions.FindWord(text, "room"));
        }
    }
}
