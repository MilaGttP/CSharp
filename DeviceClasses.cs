
using static System.Console;

namespace Inheritance
{
    internal partial class Inheritance
    {
        class Device
        {
            public string Name { get; set; }
            public string Sounds { get; set; }
            public string Description { get; set; }
            public Device()
            {
                Name = null; Sounds = null; Description = null;
            }
            public Device(string? name, string? sound, string? description)
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
    }
}
