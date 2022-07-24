
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DelegatesAndEvents;

namespace DelegatesAndEventsTests
{
    [TestClass]
    public class CreditCardTesting
    {
        [TestMethod]
        public void Refill()
        {
            CreditCard creditCard = new CreditCard();
            CreditCardEvents events = new CreditCardEvents();
            events.refillEvent += creditCard.Refill;
            events.Refill(1000);
            Assert.AreEqual(1000, creditCard.Money);
        }
        [TestMethod]
        public void Spend()
        {
            CreditCard creditCard = new CreditCard();
            CreditCardEvents events = new CreditCardEvents();
            events.spendEvent += creditCard.Spend;
            events.Spend(1000);
            Assert.AreEqual(-1000, creditCard.Money);
        }
        [TestMethod]
        public void CreditMoney()
        {
            CreditCard creditCard = new CreditCard();
            CreditCardEvents events = new CreditCardEvents();
            events.creditMoneyEvent += creditCard.CreditMoney;
            events.CreditMoney(1000);
            Assert.AreEqual(-1000, creditCard.Limit);
        }
        [TestMethod]
        public void AchieveGivenAmount()
        {
            CreditCard creditCard = new CreditCard();
            CreditCardEvents events = new CreditCardEvents();
            events.achieveGivenAmountEvent += creditCard.AchieveGivenAmount;
            Assert.AreEqual(true, creditCard.AchieveGivenAmount(0));
        }
        [TestMethod]
        public void NewPin()
        {
            CreditCard creditCard = new CreditCard();
            CreditCardEvents events = new CreditCardEvents();
            events.changePINEvent += creditCard.ChangePIN;
            events.ChangePIN(123456);
            Assert.AreEqual(123456, creditCard.PIN);
        }
    }
}
