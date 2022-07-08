
namespace Classes
{
    internal partial class Classes
    {
        // --- Lab ---
        static void RangeMultiply(int begin, int completion, out int res)
        {
            res = 1;
            if (begin == completion || begin > completion)
                throw new ArgumentException("Wrong range!");
            for (int i = begin; i <= completion; ++i)
                res = res * i;
        }
        static bool CheckFibonacci(int number)
        {
            if (Math.Sqrt(5 * (Math.Pow(number, 2)) - 4) % 1 == 0 || Math.Sqrt(5 * (Math.Pow(number, 2)) + 4) % 1 == 0)
                return true;
            else
                return false;
        }
        static int[] MyBubbleSortByIncrease(int[] arr)
        {
            for (int i = arr.Length - 1; i > 0; --i)
            {
                for (int j = 0; j < i; ++j)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
            }
            return arr;
        }
        static int[] MyBubbleSortByDecrease(int[] arr)
        {
            for (int i = arr.Length - 1; i > 0; --i)
            {
                for (int j = 0; j < i; ++j)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
            }
            return arr;
        }

        // --- Homework ---
        static void FillAndShowSquare(int side, string symbol)
        {
            string[,] square = new string[side, side];
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    square[i, j] = symbol;
                    Console.Write($"{square[i, j]}");
                }
                Console.WriteLine();
            }
        }
        static bool IsPalindrom(int number)
        {
            var str = number.ToString();
            var str2 = new string(number.ToString().Reverse().ToArray());
            return str == str2;
        }
        static string FilteringArray(string origin, string forFilter)
        {
            System.Text.StringBuilder original = new System.Text.StringBuilder(origin);
            System.Text.StringBuilder filtering = new System.Text.StringBuilder(forFilter);
            for (int i = 0; i < original.Length; i++)
            {
                for (int j = 0; j < filtering.Length; j++)
                {
                    if (original[i] == filtering[j]) original[i] = ' ';
                }
            }
            return original.ToString();
        }
    }
}