
namespace Classes
{
    internal partial class Classes
    {
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
    }
}