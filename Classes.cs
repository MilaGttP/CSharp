
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


        class Device
        {
            public string Name { get; set; }
            public string Sounds { get; set; }
            public string Description { get; set; }
            public Device()
            {
                Name = null; Sounds = null; Description = null;
            }
            public Device(string ? name, string ? sound, string ? description)
            {
                Name = name;
                Sounds = sound;
                Description = description;
            }
            public virtual void Sound() { WriteLine($"It sounds like: {Sounds}!"); }
            public virtual void Show() { WriteLine($"Its name is: {Name}"); }
            public virtual void Desc() { WriteLine($"Its description is: {Description}\n"); }
        }
        class Kettle : Device
        { 
            public Kettle()
            {
                Name = "Kettle";
                Sounds = "Shhhhhh";
                Description = "This device is boiling water";
            }
        }
        class Microwave : Device
        {
            public Microwave()
            {
                Name = "Microwave";
                Sounds = "Chik - chik";
                Description = "This an electrical appliance that allows heating " +
                    " water-containing substances due to electromagnetic radiation";
            }
        }
        class Car : Device
        {
            public Car()
            {
                Name = "Car";
                Sounds = "Broom - broom";
                Description = "This device allows you to drive everywhere";
            }
        }
        class Steamship : Device
        {
            public Steamship()
            {
                Name = "Steamship";
                Sounds = "Ouuu";
                Description = "This is a ship equipped with a reciprocating steam " +
                    " engine or a steam turbine as a propulsion engine";
            }
        }


        class MusicalInstrument
        {
            public string Name { get; set; }
            public string Sounds { get; set; }
            public string Description { get; set; }
            public string Story { get; set; }
            public MusicalInstrument()
            {
                Name = null; Sounds = null; Description = null; Story = null; 
            }
            public MusicalInstrument(string? name, string? sound, string? description, string ? history)
            {
                Name = name;
                Sounds = sound;
                Description = description;
                Story = history;
            }
            public virtual void Sound() { WriteLine($"It sounds like: {Sounds}!"); }
            public virtual void Show() { WriteLine($"Its name is: {Name}"); }
            public virtual void Desc() { WriteLine($"Its description is: {Description}\n"); }
            public virtual void History() { WriteLine($"Its history is: {Story}\n"); }
        }
        class Violin : MusicalInstrument
        {
            public Violin()
            {
                Name = "Violin";
                Sounds = "Sounds like a violin";
                Description = "Two-stringed, bowed instruments, played upright and strung and bowed with horsehair";
                Story = "The direct ancestor of all European bowed instruments is the Arabic rebab (ربابة), " +
                    " which developed into the Byzantine lyra by the 9th century and later the European rebec";
            }
        }
        class Trombone : MusicalInstrument
        {
            public Trombone()
            {
                Name = "Trombone";
                Sounds = "Sounds like a trombone";
                Description = "Like a trumpet, it has a cylindrical bore flared to a bell. Its mouthpiece is larger," +
                    " however, suited to its deeper musical register, and is parabolic in cross section, like a cornet.";
                Story = "The trombone is a 15th-century development of the trumpet and, until approximately 1700, was known as the sackbut";
            }
        }
        class Ukulele : MusicalInstrument
        {
            public Ukulele()
            {
                Name = "Ukulele";
                Sounds = "Sounds like a ukulele";
                Description = "The braguinha is a stringed instrument smaller " +
                    " than a guitar whose tuning is very similar to the first four strings of a guitar.";
                Story = "While the ukulele is a uniquely Hawaiian instrument," +
                    " its roots are in the Portuguese braguinha or machete de braga";
            }
        }
        class Cello : MusicalInstrument
        {
            public Cello()
            {
                Name = "Cello";
                Sounds = "Sounds like a cello";
                Description = "The cello, about 27.5 inches (70 cm) long (47 inches [119 cm] with the neck)," +
                    " has proportionally deeper ribs and a shorter neck than the violin.";
                Story = "The earliest cellos were developed during the 16th century and frequently" +
                    " were made with five strings";
            }
        }


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