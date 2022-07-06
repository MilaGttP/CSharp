
using static System.Console;

namespace Inheritance
{
    internal partial class Inheritance
    {
        abstract class Worker
        {
            public string Name { get; set; }
            public string Position { get; set; }
            public string Responsibilities { get; set; }
            public Worker()
            {
                Name = null; Position = null; Responsibilities = null;
            }
            public Worker(string ? name, string ? position, string ? responsibilities)
            {
                Name = name; Position = position; Responsibilities = responsibilities;
            }
            public abstract void Print();
        }
        class President : Worker
        {
            public President()
            {
                Name = "Volodymyr Zelensky";
                Position = "President";
                Responsibilities = "Manage a country";
            }
            public override void Print()
            {
                WriteLine($"President information:\n Name: {Name}\n Responsibilities: {Responsibilities}\n ");
            }
        }
        class Security : Worker
        {
            public Security()
            {
                Name = "Ivan Koval";
                Position = "Security";
                Responsibilities = "Safe something";
            }
            public override void Print()
            {
                WriteLine($"Security information:\n Name: {Name}\n Responsibilities: {Responsibilities}\n ");
            }
        }
        class Manager : Worker
        {
            public Manager()
            {
                Name = "Sergiy Us";
                Position = "Manager";
                Responsibilities = "Help clients";
            }
            public override void Print()
            {
                WriteLine($"Manager information:\n Name: {Name}\n Responsibilities: {Responsibilities}\n ");
            }
        }
        class Engineer : Worker
        {
            public Engineer()
            {
                Name = "Dmitriy Melnik";
                Position = "Engineer";
                Responsibilities = "Invent something";
            }
            public override void Print()
            {
                WriteLine($"Engineer information:\n Name: {Name}\n Responsibilities: {Responsibilities}\n ");
            }
        }
    }
}