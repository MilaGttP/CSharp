
using static System.Console;

namespace Introduction
{
    internal partial class Introduction
    {
        static void FizzBuzz()
        {
            WriteLine("\n --- FizzBuzz --- ");
            Write("Enter a number -> ");
            int number = Convert.ToInt32(ReadLine());
            if (number < 0 || number > 100)
                throw new Exception("Number is more than 100 or less than 0");
            else
            {
                if (number % 3 == 0) WriteLine("Fizz");
                else if (number % 5 == 0) WriteLine("Buzz");
                else if (number % 3 == 0 && number % 5 == 0) WriteLine("Fizz Buzz");
                else WriteLine($"Number: {number}");
            }
        }
        static void Percents()
        {
            WriteLine("\n --- Percents --- ");
            Write("Enter a value -> ");
            int value = Convert.ToInt32(ReadLine());
            Write("Enter a percent -> ");
            int percent = Convert.ToInt32(ReadLine());
            int res = value * percent / 100;
            WriteLine($"Result: {res}");
        }
        static void SingleNumber()
        {
            WriteLine("\n --- SingleNumber --- ");
            int[] arr = new int[4];
            for (int i = 0; i < 4; ++i)
            {
                Write($"Enter {i} number -> ");
                arr[i] = Convert.ToInt32(ReadLine());
            }
            Write($"Your single number: {String.Join("", arr)}");
        }
        static void ReverseConcreteNumbers()
        {
            WriteLine("\n --- ReverseConcreteNumbers --- ");
            int size = 6;
            int[] arr = new int[size];
            for (int i = 0; i < size; ++i)
            {
                Write($"Enter {i} number -> ");
                arr[i] = Convert.ToInt32(ReadLine());
            }
            WriteLine($"Your list of numbers: {String.Join(", ", arr)}");
            Array.Reverse(arr);
            WriteLine(String.Join(", ", arr));
        }
        static void Date()
        {
            WriteLine("\n --- Date --- ");
            Write("Enter date -> "); string dateTime = ReadLine();
            DateTime date = DateTime.Parse(dateTime);
            string month = date.Month.ToString();
            if (date.Month == 0 || date.Month > 12 || date.Month < 0) throw new Exception("Wrong month!");
            else if (date.Month >= 3 && date.Month <= 5) month = "Spring";
            else if (date.Month >= 6 && date.Month <= 8) month = "Summer";
            else if (date.Month >= 9 && date.Month <= 11) month = "Autumn";
            else month = "Winter";
            WriteLine($" Day: {date.Day}\n Day of the week: {date.DayOfWeek}\n Month: {date.Month} ({month})\n Year: {date.Year}");
        }
        static void Degrees()
        {
            WriteLine("\n --- Degrees --- ");
            Write("Enter a degree value -> ");
            int value = Convert.ToInt32(ReadLine());
            Write($" Fahrenheit -> Celsius is 1\n Celsius -> Fahrenheit is 2 \n\n Enter -> ");
            int tmp = Convert.ToInt32(ReadLine());
            double result = 0;
            switch (tmp)
            {
                case 1:
                    result = (value - 32) * 0.5556;
                    WriteLine($"Result of convertation: {result} C");
                    break;
                case 2:
                    result = (value * 1.8) + 32;
                    WriteLine($"Result of convertation: {result} F");
                    break;
            }
        }
        static void EvenNumbers()
        {
            WriteLine("\n --- EvenNumbers --- ");
            Write("Enter first value -> ");
            int first = Convert.ToInt32(ReadLine());
            Write("Enter second value -> ");
            int second = Convert.ToInt32(ReadLine());
            if (first > second)
            {
                int tmp = first;
                first = second;
                second = tmp;
                WriteLine("First and second are reversed.");
            }
            WriteLine("Even numbers: ");
            for(int i = first; i <= second; i++)
                if (i % 2 == 0) Write($" {i}");
        }
    }
}