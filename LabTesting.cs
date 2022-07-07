
using static System.Console;

namespace Classes
{
    internal partial class Classes
    {
        static void TestRangeMultiply()
        {
            int begin = 0, completion = 0, res = 0;
            Write("Enter range`s begin -> ");
            begin = Convert.ToInt32(ReadLine());
            Write("Enter range`s completion -> ");
            completion = Convert.ToInt32(ReadLine());
            RangeMultiply(begin, completion, out res);
            WriteLine($"Result is: {res}");
        }
        static void TestCheckFibonacci()
        {
            int number = 0;
            Write("Enter your number -> ");
            number = Convert.ToInt32(ReadLine());
            if (CheckFibonacci(number) == false)
                WriteLine("Your number isn`t a Fibonacci number!");
            else
                WriteLine("Your number is a Fibonacci number!");
        }
        static void TestMyBubbleSort()
        {
            Random random = new Random();   
            int size = 0, tmp = 0;
            Write($"Enter array size -> ");
            size = Convert.ToInt32(ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
                arr[i] = random.Next(0, 20);
            Write("Your array ->  ");
            foreach (var elem in arr)
                Write($"{elem}\t");
            WriteLine();
            WriteLine("Which sorting? \n 0 - By increase \n 1 - By decrease");
            Write("Enter -> ");
            tmp = Convert.ToInt32(ReadLine());
            switch(tmp)
            {
                case 0:
                    MyBubbleSortByIncrease(arr);
                    break;
                case 1:
                    MyBubbleSortByDecrease(arr);
                    break;
            }
            var sortedArr = string.Join("\t", arr);
            WriteLine($"Sorted array -> {sortedArr}");
        }
        static void TestClassCity()
        {
            City city = new City();
            city.Enter();
            WriteLine(city.ToString());
            City otherCity = new City("Vinnitsia", "Ukraine", 380000, 38, "Vyshenka, Kyivska");
            WriteLine(otherCity.ToString());
        }
        static void TestClassEmployer()
        {
            Employer employer = new Employer();
            employer.Enter();
            WriteLine(employer.ToString());
            Employer otherEmployer = new Employer("Dmitriy Qwertt", "12.12.2000", 0981232125, "DW@mail.com", "Team lead", "Controls team");
            WriteLine(otherEmployer.ToString());
        }
        static void TestClassAirplane()
        {
            Airplane airplane = new Airplane();
            airplane.Enter();
            WriteLine(airplane.ToString());
            Airplane otherAirplane = new Airplane("Mriya", "KiAPO", 1984, "AN - 225");
            WriteLine(otherAirplane.ToString());
        }
        static void TestClassMatrix()
        {
            Matrix matrix = new Matrix();
            matrix.Enter();
            WriteLine(matrix.ToString());
            WriteLine($"Matrix max: {matrix.MatMax()}");
            WriteLine($"Matrix min: {matrix.MatMin()}");
        }
    }
}
