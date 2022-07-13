
using static System.Console;

namespace OperatorOverload
{
    public class Shop
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Description { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public double Area { get; set; }
        public Shop()
        {
            Name = null;
            Address = null;
            Description = null;
            Phone = null;
            Email = null;
            Area = 0;
        }
        public Shop (double Area) { this.Area = Area; }
        public Shop(string? Name, string? Address, string? Description, string? Phone, string? Email, double Area)
        {
            this.Name = Name;
            this.Address = Address;
            this.Description = Description;
            this.Phone = Phone;
            this.Email = Email;
            this.Area = Area;
        }
        public void Enter()
        {
            Write("Enter name -> "); Name = ReadLine();
            Write("Enter address -> "); Address = ReadLine();
            Write("Enter description -> "); Description = ReadLine();
            Write("Enter phone -> "); Phone = ReadLine();
            Write("Enter email -> "); Email = ReadLine();
            Write("Enter area -> "); Area = Convert.ToInt32(ReadLine());
        }
        public static Shop operator + (Shop s, int n)
        {
            s.Area += n;
            return s;
        }
        public static Shop operator - (Shop s, int n)
        {
            s.Area -= n;
            return s;
        }
        public static bool operator == (Shop s1, Shop s2)
        {
            return s1.Area == s2.Area;
        }
        public static bool operator != (Shop s1, Shop s2)
        {
            return s1.Area != s2.Area;
        }
        public static bool operator > (Shop s1, Shop s2)
        {
            return s1.Area > s2.Area;
        }
        public static bool operator < (Shop s1, Shop s2)
        {
            return s1.Area < s2.Area;
        }
        public override bool Equals(Object obj)
        {
            return obj is Shop && this == (Shop)obj;
        }
        public override string ToString()
        {
            return $"Shop information:\n Name: {Name}\n Address: {Address}\n " +
                $"Description: {Description}\n Phone: {Phone}\n Email: {Email}\n Area: {Area}\n";
        }
    }
}
