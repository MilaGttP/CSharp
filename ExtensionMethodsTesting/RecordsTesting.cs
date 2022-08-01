
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Records;

namespace RecordsTesting
{
    [TestClass]
    public class RecordsTesting
    {
        [TestMethod]
        public void DayTemperatureTest()
        {
            DayTemperature first = new DayTemperature(18, 24);
            DayTemperature second = new DayTemperature(17, 25);
            DayTemperature third = new DayTemperature(19, 21);
            ForRecords forRecords = new ForRecords();
            Assert.AreEqual(8, forRecords.MaxTemperatureDifference(first, second, third));
        }
        [TestMethod]
        public void MaxMediumMarkTest()
        {
            Marks first = new Marks(10, 12, 11);
            Marks second = new Marks(9, 8, 7);
            Marks third = new Marks(11, 12, 11);
            ForRecords forRecords = new ForRecords();
            Assert.AreEqual(11, forRecords.MaxMediumMark(first, second, third));
        }
        [TestMethod]
        public void AverageMediumMarkTest()
        {
            Marks first = new Marks(10, 10, 11);
            Marks second = new Marks(9, 8, 7);
            Marks third = new Marks(11, 12, 11);
            ForRecords forRecords = new ForRecords();
            Assert.AreEqual(10, forRecords.AverageMediumMark(first, second, third));
        }
    }
}