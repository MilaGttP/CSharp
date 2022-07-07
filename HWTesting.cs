
using static System.Console;

namespace Classes
{
    internal partial class Classes
    {
        static void SquareSymbolTest()
        {
            Write("Enter a square side -> "); int side = Convert.ToInt32(ReadLine());
            Write("Enter a symbol -> "); string symbol = ReadLine();
            FillAndShowSquare(side, symbol);
        }
        static void PalindromTest()
        {
            Write("Enter your number -> "); int number = Convert.ToInt32(ReadLine());
            if (IsPalindrom(number) == true) WriteLine("Your number is a palindrom!");
            else WriteLine("Your number isn`t a palindrom!");
        }
        static void FilterArrayTest()
        {
            Write("Enter an origin array -> "); string origin = ReadLine();
            Write("Enter a filtering array -> "); string filtering = ReadLine();
            WriteLine($"Resulting array: {FilteringArray(origin, filtering)}");
        }

    }
}