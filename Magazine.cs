
using static System.Console;

namespace OperatorOverload
{
    public class Magazine
    {
        public string? Name { get; set; }
        public int? Year { get; set; }
        public string? Description { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public int WorkerQuantity { get; set; }
        public Magazine()
        {
            Name = null;
            Year = 0;
            Description = null;
            Phone = null;
            Email = null;
            WorkerQuantity = 0;
        }
        public Magazine (int WorkerQuantity) { this.WorkerQuantity = WorkerQuantity; }
        public Magazine(string? Name, int? Year, string? Description, string? Phone, string? Email, int WorkerQuantity)
        {
            this.Name = Name;
            this.Year = Year;
            this.Description = Description;
            this.Phone = Phone;
            this.Email = Email;
            this.WorkerQuantity = WorkerQuantity;
        }
        public void Enter()
        {
            Write("Enter name -> "); Name = ReadLine();
            Write("Enter year -> "); Year = Convert.ToInt32(ReadLine());
            Write("Enter description -> "); Description = ReadLine();
            Write("Enter phone -> "); Phone = ReadLine();
            Write("Enter email -> "); Email = ReadLine();
            Write("Enter worker quantity -> "); WorkerQuantity = Convert.ToInt32(ReadLine());
        }
        public static Magazine operator + (Magazine m, int n)
        {
            m.WorkerQuantity += n;
            return m;
        }
        public static Magazine operator - (Magazine m, int n)
        {
            m.WorkerQuantity -= n;
            return m;
        }
        public static bool operator == (Magazine m1, Magazine m2)
        {
            return m1.WorkerQuantity == m2.WorkerQuantity;
        }
        public static bool operator != (Magazine m1, Magazine m2)
        {
            return m1.WorkerQuantity != m2.WorkerQuantity;
        }
        public static bool operator > (Magazine m1, Magazine m2)
        {
            return m1.WorkerQuantity > m2.WorkerQuantity;
        }
        public static bool operator < (Magazine m1, Magazine m2)
        {
            return m1.WorkerQuantity < m2.WorkerQuantity;
        }
        //public override bool Equals(object obj) // - is not correct
        //{
        //    return this.ToString() == obj.ToString();
        //}
        public override bool Equals(Object obj)
        {
            return obj is Magazine && this == (Magazine)obj;
        }
        public override string ToString()
        {
            return $"Magazine information:\n Name: {Name}\n Year: {Year}\n " +
                $"Description: {Description}\n Phone: {Phone}\n Email: {Email}\n Worker quantity: {WorkerQuantity}\n";
        }
    }
}