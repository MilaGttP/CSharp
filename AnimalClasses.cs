
namespace AbsClasses
{
    public partial class AbstractClasses
    {
        public class Animal
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public string Activity { get; set; }
            public Animal()
            {
                Name = null;
                Type = null;
                Activity = null;
            }
            public Animal(string name, string type, string activity)
            {
                Name = name;
                Type = type;
                Activity = activity;
            }
            public void Enter()
            {
                Console.Write("Enter name -> "); Name = Console.ReadLine();
                Console.Write("Enter animal type name -> "); Type = Console.ReadLine();
                Console.Write("Enter activity -> "); Activity = Console.ReadLine();
            }
            public override string ToString()
            {
                return $"{Type} information: \n Name: {Name}\n Type: {Type}\n Activity: {Activity}";
            }
        }
        class Tiger : Animal { }
        class Crocodile : Animal { }
        class Kangaroo : Animal { }
    }
} 
