
using static System.Console;

namespace Classes
{
    class City
    {
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public int Population { get; set; }
        public int PhoneCode { get; set; }
        public string AreasName { get; set; }
        public City()
        {
            CityName = null;
            CountryName = null;
            Population = 0;
            PhoneCode = 0;
            AreasName = null;
        }
        public City(string ? CityName, string ? CountryName, int Population, int PhoneCode, string AreasName)
        {
            this.CityName = CityName;
            this.CountryName = CountryName;
            this.Population = Population;
            this.PhoneCode = PhoneCode;
            this.AreasName = AreasName;
        }
        public void Enter()
        {
            Write("Enter city name -> "); CityName = Convert.ToString(ReadLine());
            Write("Enter country name -> "); CountryName = Convert.ToString(ReadLine());
            Write("Enter population -> "); Population = Convert.ToInt32(ReadLine());
            Write("Enter phone code -> "); PhoneCode = Convert.ToInt32(ReadLine());
            Write("Enter areas -> "); AreasName = Convert.ToString(ReadLine());
        }
        public override string ToString()
        {
            return $"City information:\n CityName: {CityName}\n CountryName: {CountryName}\n " +
                $"Population: {Population}\n PhoneCode: {PhoneCode}\n AreasName: {AreasName}\n";
        }
    }
    class Employer
    {
        public string FullName { get; set; }
        public string Birthday { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string WorkDescription { get; set; }
        public Employer()
        {
            FullName = null;
            Birthday = null;
            Phone = 0;
            Email = null;
            Position = null;
            WorkDescription = null;
        }
        public Employer(string ? FullName, string ? Birthday, int Phone, string ? Email, string ? Position, string ? WorkDescription)
        {
            this.FullName = FullName; 
            this.Birthday = Birthday;
            this.Phone = Phone;
            this.Email = Email;
            this.Position = Position;
            this.WorkDescription = WorkDescription;
        }
        public void Enter()
        {
            Write("Enter your full name -> "); FullName = Convert.ToString(ReadLine());
            Write("Enter your birthday -> "); Birthday = Convert.ToString(ReadLine());
            Write("Enter your phone -> "); Phone = Convert.ToInt32(ReadLine());
            Write("Enter your email -> "); Email = Convert.ToString(ReadLine());
            Write("Enter your position -> "); Position = Convert.ToString(ReadLine());
            Write("Enter work description -> "); WorkDescription = Convert.ToString(ReadLine());
        }
        public override string ToString()
        {
            return $"Employer information:\n FullName: {String.Join(", ", FullName)}\n Birthday: {Birthday}\n Phone: {Phone}\n " +
                $"Email: {Email}\n Position: {Position}\n WorkDescription: {WorkDescription}\n";
        }
    }
    class Airplane
    {
        public string AirplaneName { get; set; }
        public string AuthorName { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public Airplane()
        {
            AirplaneName = null;
            AuthorName = null;
            Year = 0;
            Type = null;
        }
        public Airplane(string? AirplaneName, string? AuthorName, int Year, string? Type)
        {
            this.AirplaneName = AirplaneName;
            this.AuthorName = AuthorName;
            this.Year = Year;
            this.Type = Type;
        }
        public void Enter()
        {
            Write("Enter airplane name -> "); AirplaneName = Convert.ToString(ReadLine());
            Write("Enter manufacturer name -> "); AuthorName = Convert.ToString(ReadLine());
            Write("Enter year -> "); Year = Convert.ToInt32(ReadLine());
            Write("Enter type -> "); Type = Convert.ToString(ReadLine());
        }
        public override string ToString()
        {
            return $"Airplane information:\n AirplaneName: {AirplaneName}\n " +
                $"AuthorName: {AuthorName}\n Year: {Year}\n Type: {Type}\n";
        }
    }
    class Matrix
    {
        public int Size { get; set; }
        public int[] Filling { get; set; }
        public Matrix()
        {
            Size = 0;
            Filling = new int[Size];
        }
        public void Enter()
        {
            Write($"Enter size -> ");
            Size = Convert.ToInt32(ReadLine());
            Filling = new int[Size];
            for (int i = 0; i < Size; i++)
            {
                Write("Enter your values -> ");
                Filling[i] = Convert.ToInt32(ReadLine());
            }
        }
        public int MatMin()
        {
            int min = Filling.Min();
            return min;
        }
        public int MatMax()
        {
            int max = Filling.Max();
            return max;
        }
        public override string ToString()
        {
            return $"Matrix information:\n Size: {Size}\n " +
                $"Filling: {String.Join(", ", Filling)}\n";
        }
    }
}
