
namespace AbsClasses
{
    public partial class AbstractClasses
    {
        public abstract class Passport
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string SomeData { get; set; }
            public Passport()
            {
                Name = null;
                Age = 0;
                SomeData = null;
            }
            public Passport(string name, int age, string someData)
            {
                Name = name;
                Age = age;
                SomeData = someData;
            }
            public abstract void Enter();
            public abstract string ToString();
        }
        public class ForeignPassport : Passport
        {
            public string VisaData { get; set; }
            public int PassNumber { get; set; }
            public ForeignPassport() : base()
            {
                VisaData = null;
                PassNumber = 0;
            }
            public ForeignPassport(string name, int age, string someData, string visaData, int passNum) : base(name, age, someData)
            {
                VisaData = visaData;
                PassNumber = passNum;
            }
            public override void Enter()
            {
                Console.Write("Enter full name -> "); Name = Console.ReadLine();
                Console.Write("Enter age -> "); Age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter some data -> "); SomeData = Console.ReadLine();
                Console.Write("Enter visa data -> "); VisaData = Console.ReadLine();
                Console.Write("Enter passport number -> "); PassNumber = Convert.ToInt32(Console.ReadLine());
            }
            public override string ToString()
            {
                return $"{Name} information: \n Full name: {Name}\n Age: {Age}, " +
                    $"Some data: {SomeData}\n Visa data: {VisaData}\n Passport number: {PassNumber}";
            }
        }
    }
}
