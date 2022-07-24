
namespace DelegatesAndEvents
{
    public delegate void CreditCardDelegate(int value);
    public class CreditCard
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int PIN { get; set; }
        public int Limit { get; set; }
        public int Money { get; set; }
        public void Refill(int sum) { Money += sum; }
        public void Spend(int sum) { Money -= sum; }
        public void CreditMoney(int money) { Limit -= money; }
        public bool AchieveGivenAmount(int amount)
        {
            if (Money == amount) return true;
            else return false;
        }
        public void ChangePIN(int newPin) { PIN = newPin; }
    }
    public class CreditCardEvents
    {
        public event CreditCardDelegate refillEvent;
        public void Refill(int sum)
        {
            if (refillEvent != null) refillEvent(sum);
        }
        public event CreditCardDelegate spendEvent;
        public void Spend(int sum)
        {
            if (spendEvent != null) spendEvent(sum);
        }
        public event CreditCardDelegate creditMoneyEvent;
        public void CreditMoney(int money)
        {
            if (creditMoneyEvent != null) creditMoneyEvent(money);
        }
        public delegate bool CreditCardBoolDelegate(int value);
        public event CreditCardBoolDelegate achieveGivenAmountEvent;
        public bool AchieveGivenAmount(int amount)
        {
            if (achieveGivenAmountEvent != null)
            {
                achieveGivenAmountEvent(amount);
                return true;
            }
            else return false;
        }
        public event CreditCardDelegate changePINEvent;
        public void ChangePIN(int newPin)
        {
            if (changePINEvent != null) changePINEvent(newPin);
        }
    }
}
