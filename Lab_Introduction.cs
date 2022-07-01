
using static System.Console;

namespace Introduction
{
    internal partial class Introduction
    {
        static void WriteQuote()
        {
            WriteLine("\n --- WriteQuote --- ");
            WriteLine("It's easy to win forgiveness for being wrong;");
            WriteLine("being right is what gets you into real trouble.");
            WriteLine("Bjarne Stroustrup");
        }
        static void FiveNumbers()
        {
            WriteLine("\n --- FiveNumbers --- ");
            int size = 5;
            int[] arr = new int[size];
            for (int i = 0; i < size; ++i)
            {
                Write("Enter number -> ");
                arr[i] = Convert.ToInt32(ReadLine());
            }
            WriteLine("Your list of numbers: ");
            WriteLine(String.Join(", ", arr));
            int mult = 1;
            foreach (int value in arr)
                mult *= value;
            WriteLine($"Multiply is: {mult}");
            int sum = arr.Sum();
            WriteLine($"Sum is: {sum}");
            WriteLine($"Minimal value is: {arr.Min()}");
            WriteLine($"Maximum value is: {arr.Max()}");
        }
        static void ReverseNumber()
        {
            WriteLine("\n --- ReverseNumber --- ");
            int size = 6;
            int[] arr = new int[size];
            for (int i = 0; i < size; ++i)
            {
                Write("Enter number -> ");
                arr[i] = Convert.ToInt32(ReadLine());
            }
            WriteLine("Your regular list of numbers: ");
            WriteLine(String.Join(", ", arr));
            Array.Reverse(arr);
            WriteLine("Your reversed list of numbers: ");
            WriteLine(String.Join(", ", arr));
        }
        static void FibonacciNumbers()
        {
            WriteLine("\n --- FibonacciNumbers --- ");
            int max;
            Write($"Enter max of the range -> ");
            max = Convert.ToInt32(ReadLine());
            int j = 1;
            for (int i = 1; i <= max; i += j)
            {
                Write("{0} ", i);
                j = i - j;
            }
        }
        static void PositiveIntegers()
        {
            WriteLine("\n --- PositiveIntegers --- ");
            int a, b;
            Write($"Enter a -> ");
            a = Convert.ToInt32(ReadLine());
            Write($"Enter b -> ");
            b = Convert.ToInt32(ReadLine());
            for (WriteLine(); a <= b; WriteLine(), a++)
                for (int i = 1; i <= a; i++)
                    Write("{0}", a);
        }
        static void Lines()
        {
            WriteLine("\n --- Lines --- ");
            int count, whichLine, i = 1; char ch;
            Write($" Enter a symbol -> ");
            ch = Convert.ToChar(ReadLine());
            Write($" Enter symbol quantity -> ");
            count = Convert.ToInt32(ReadLine());
            Write($" Horizontal line is 1\n Vertical line is 2 \n\n Enter -> ");
            whichLine = Convert.ToInt32(ReadLine());
            while (i <= count)
            {
                switch (whichLine)
                {
                    case 1:
                        {
                            Write(ch);
                            i++;
                        }
                        break;
                    case 2:
                        {
                            WriteLine(ch);
                            i++;
                        }
                        break;
                }
            }
        }
    }
}