
namespace ArraysStrings
{
    internal partial class ArraysStrings
    {
        public static int MaxOneD(int row, int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < row; i++)
                if (max < arr[i]) max = arr[i];
            return max;
        }
        public static int MaxTwoD(int col, int row, int[,] arr)
        {
            int max = int.MaxValue;
            for (int i = 0; i < col; i++)
                for (int j = 0; j < row; j++)
                    if (arr[i, j] < 0 && arr[i, j] > max) max = arr[i, j];
            return max;
        }
        public static int MinOneD(int row, int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < row; i++)
                if (min > arr[i]) min = arr[i];
            return min;
        }
        public static int MinTwoD(int col, int row, int[,] arr)
        {
            int min = int.MinValue;
            for (int i = 0; i < col; i++)
                for (int j = 0; j < row; j++)
                    if (arr[i, j] > 0 && arr[i, j] < min) min = arr[i, j];
            return min;
        }
        public static int Maximum(int[] A, int[,] B)
        {
            if(MaxOneD(5, A) == MaxTwoD(3, 4, B)) return MaxOneD(5, A);
            else return 0;
        }
        public static int Minimum(int[] A, int[,] B)
        {
            if (MinOneD(5, A) == MinTwoD(3, 4, B)) return MinOneD(5, A);
            else return 0;
        }
        public static int Sum(int[] A, int[,] B)
        {
            int sumA = A[0], sumB = B[0, 0];
            foreach (var value in A) sumA += value;
            foreach (var value in B) sumB += value;
            int sum = sumA + sumB;
            return sum;
        }
        public static int Multiply(int[] A, int[,] B)
        {
            int prodA = 1, prodB = 1; ;
            for (int i = 0; i < A.GetLength(0); i++) prodA *= A[i];
            for (int i = 0; i < B.GetLength(0); i++)
                for (int j = 0; j < B.GetLength(1); j++) prodB *= B[i, j];
            int prod = prodA * prodB;
            return prod;
        }
        public static int EvenA(int[] A)
        {
            int sum = 0;
            for (int i = 0; i < A[0]; i++) 
                if (A[i] % 2 == 0) sum += A[i];
            return sum;
        }
        public static int UnevenB(int[,] B)
        {
            int sum = 0, maxS = int.MinValue, column = 0;
            for (int i = 0; i < B.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < B.GetLength(0); j++) sum += B[j, i];
                if (sum > maxS)
                {
                    maxS = sum;
                    column = i + 1;
                }
            }
            return sum;
        }
    }
}
