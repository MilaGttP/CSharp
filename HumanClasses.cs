
namespace AbsClasses
{
    public partial class AbstractClasses
    {
        class Human
        {
            public string FullName { get; set; }
            public int Age { get; set; }
            public string Profession { get; set; }
            public string WorkDescription { get; set; }
            public Human()
            {
                FullName = null;
                Age = 0;
                Profession = null;
                WorkDescription = null;
            }
            public Human(string fullName, int age, string profession, string workDes)
            {
                FullName = fullName;
                Age = age;
                Profession = profession;
                WorkDescription = workDes;
            }
            public void Enter()
            {
                Console.Write("Enter profession -> "); Profession = Console.ReadLine();
                Console.Write($"Enter {Profession} full name -> "); FullName = Console.ReadLine();
                Console.Write("Enter age -> "); Age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter work description -> "); WorkDescription = Console.ReadLine();
            }
            public override string ToString()
            {
                return $"{Profession} information: \n Full name: {FullName}\n Age: {Age}\n Work description: {WorkDescription}";
            }
        }
        class Builder : Human { }
        class Sailor : Human { }
        class Pilot : Human { }
    }
}