
using static System.Console;

namespace Inheritance
{
    internal partial class Inheritance
    {
        class Money
        {
            public int Entire { get; set; }
            public double Cents { get; set; }
            public string Type { get; set; }
            public Money()
            {
                Entire = 0; Cents = 0; Type = null;
            }
            public Money(int entire, double cents, string type)
            {
                Entire = entire;
                Cents = cents;
                Type = type;
            }
            public void EnterMoney()
            {
                Write("Enter entire part of money -> "); Entire = Convert.ToInt32(ReadLine());
                Write("Enter cents -> "); Cents = Convert.ToInt32(ReadLine());
                Write("Enter money type -> "); Type = Convert.ToString(ReadLine());
            }
            public override string ToString()
            {
                return $"Money information: {Entire}.{Cents} {Type}\n";
            }
        }
        class Product : Money
        {
            public string Name { get; set; }
            public string ExpirationDate { get; set; }
            public void EnterProduct()
            {
                Write("Enter product name -> "); Name = Convert.ToString(ReadLine());
                Write("Enter expiration date -> "); ExpirationDate = Convert.ToString(ReadLine());
                EnterMoney();
            }
            public override string ToString()
            {
                return $"Product information:\n Name: {Name}\n ExpirationDate: {ExpirationDate}\n Price: {Entire}.{Cents} {Type}\n";
            }
            public void Discount()
            {
                int discEntire; double discCents;
                Write("Enter discount`s entire part -> "); discEntire = Convert.ToInt32(ReadLine());
                Write("Enter discount`s cents -> "); discCents = Convert.ToInt32(ReadLine());
                WriteLine($"Your discount is: {discEntire}.{discCents} {Type}");
                WriteLine($"Your past price is: {Entire}.{Cents} {Type}");
                Entire -= discEntire; Cents -= discCents;
                WriteLine($"Now product`s price is: {Entire}.{Cents} {Type}\n");
            }
        }
    }
}