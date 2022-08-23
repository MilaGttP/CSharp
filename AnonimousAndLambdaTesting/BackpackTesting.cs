using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnonMethodsAndLambda;

namespace AnonimousAndLambdaTesting
{
    [TestClass]
    public class BackpackTesting
    {
        [TestMethod]
        public void AddItem()
        {
            Backpack backpack = new Backpack("red", "authoe", "eco - leather", 1.2, 7.8);
            backpack.addingEvent += delegate (double volume, string name) { backpack.Items.Add(volume, name); };
            backpack.AddItem(0.4, "pen"); 
            string res = null;
            foreach (var e in backpack.Items.Keys) res = $"{e}, {backpack.Items[e]}";
            Assert.AreEqual("0,4, pen", res);
        }
    }
}
