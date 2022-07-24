
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DelegatesAndEvents;

namespace DelegatesAndEventsTests
{
    [TestClass]
    public class DateAndTimeTesting
    {
        [TestMethod]
        public void GetCurrentDateTime_Return_21072022_1247()
        {
            DateAndTime dt = new DateAndTime();
            DateAndTimeDelegate<string> getCurrentDelegate = new DateAndTimeDelegate<string>(dt.GetCurrentDateTime);
            Assert.AreEqual("24.07.2022 14:43", getCurrentDelegate());
        }
        [TestMethod]
        public void GetCurrentDate_Return21072022()
        {
            DateAndTime dt = new DateAndTime();
            DateAndTimeDelegate<string> getCurrentDelegate = new DateAndTimeDelegate<string>(dt.GetCurrentDate);
            Assert.AreEqual("24.07.2022", getCurrentDelegate());
        }
        [TestMethod]
        public void GetCurrentDayOfWeek_ReturnThursday()
        {
            DateAndTime dt = new DateAndTime();
            DateAndTimeDelegate<string> getCurrentDelegate = new DateAndTimeDelegate<string>(dt.GetCurrentDayOfWeek);
            Assert.AreEqual("Sunday", getCurrentDelegate());
        }
    }
}