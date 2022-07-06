
using static System.Console;

namespace Inheritance
{
    internal partial class Inheritance
    {
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
            public MusicalInstrument(string? name, string? sound, string? description, string? history)
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
    }
}
