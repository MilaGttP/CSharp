
using static System.Console;

namespace Classes
{
    internal partial class Classes
    {
        class Website
        {
            public string ? Name { get; set; }
            public string ? Url { get; set; }
            public string? Description { get; set; }
            public string? Ip { get; set; }
            public Website()
            {
                Name = null;
                Url = null;
                Description = null;
                Ip = null;
            }
            public Website(string? Name, string? Url, string ? Description, string ? Ip)
            {
                this.Name = Name;
                this.Url = Url;
                this.Description = Description;
                this.Ip = Ip;
            }
            public void Enter()
            {
                Write("Enter name -> "); Name = ReadLine();
                Write("Enter url -> "); Url = ReadLine();
                Write("Enter description -> "); Description = ReadLine();
                Write("Enter ip -> "); Ip = ReadLine();
            }
            public override string ToString()
            {
                return $"Website information:\n Name: {Name}\n Url: {Url}\n " +
                    $"Description: {Description}\n Ip: {Ip}\n";
            }
        }
        class Magazine
        {
            public string? Name { get; set; }
            public int ? Year { get; set; }
            public string? Description { get; set; }
            public string ? Phone { get; set; }
            public string ? Email { get; set; }
            public Magazine()
            {
                Name = null;
                Year = 0;
                Description = null;
                Phone = null;
                Email = null;
            }
            public Magazine(string? Name, int ? Year, string? Description, string ? Phone, string ? Email)
            {
                this.Name = Name;
                this.Year = Year;
                this.Description = Description;
                this.Phone = Phone;
                this.Email = Email;
            }
            public void Enter()
            {
                Write("Enter name -> "); Name = ReadLine();
                Write("Enter year -> "); Year = Convert.ToInt32(ReadLine());
                Write("Enter description -> "); Description = ReadLine();
                Write("Enter phone -> "); Phone = ReadLine();
                Write("Enter email -> "); Email = ReadLine();
            }
            public override string ToString()
            {
                return $"Magazine information:\n Name: {Name}\n Year: {Year}\n " +
                    $"Description: {Description}\n Phone: {Phone}\n Email: {Email}\n";
            }
        }
        class Shop
        { 
            public string ? Name { get; set; }
            public string ? Address { get; set; }
            public string? Description { get; set; }
            public string? Phone { get; set; }
            public string? Email { get; set; }
            public Shop()
            {
                Name = null;
                Address = null;
                Description = null;
                Phone = null;
                Email = null;
            }
            public Shop(string? Name, string? Address, string? Description, string? Phone, string? Email)
            {
                this.Name = Name;
                this.Address = Address;
                this.Description = Description;
                this.Phone = Phone;
                this.Email = Email;
            }
            public void Enter()
            {
                Write("Enter name -> "); Name = ReadLine();
                Write("Enter address -> "); Address = ReadLine();
                Write("Enter description -> "); Description = ReadLine();
                Write("Enter phone -> "); Phone = ReadLine();
                Write("Enter email -> "); Email = ReadLine();
            }
            public override string ToString()
            {
                return $"Shop information:\n Name: {Name}\n Address: {Address}\n " +
                    $"Description: {Description}\n Phone: {Phone}\n Email: {Email}\n";
            }
        }
    }
}
