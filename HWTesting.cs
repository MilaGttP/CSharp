
using static System.Console;

namespace ArraysStrings
{
    internal partial class ArraysStrings
    {
        static void ABArrays()
        {
            int[] A = new int[5];
            int[,] B = new int[3, 4];
            Write("Enter 5 values -> ");
            A = ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            Write($"Array A: {String.Join(", ", A)}\n");
            Random random = new Random();
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    B[i, j] = random.Next(1, 20);
            WriteLine("Array B:  ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                    Write($" {B[i, j]}");
                WriteLine();
            }
            WriteLine($"General maximum is: {Maximum(A, B)}");
            WriteLine($"General minimum is: {Minimum(A, B)}");
            WriteLine($"General sum is: {Sum(A, B)}");
            WriteLine($"General multiply is: {Multiply(A, B)}");
            WriteLine($"Even elements sum in A array: {EvenA(A)}");
            WriteLine($"Uneven elements sum in B array: {UnevenB(B)}");
        }
        static void TwoDimensional5On5()
        {
            int[,] arr = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    arr[i, j] = random.Next(-100, 100);
            WriteLine("Array:  ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                    Write($" {arr[i, j]}");
                WriteLine();
            }
            int sum = 0;
            int min = MinTwoD(5, 5, arr);
            int max = MaxTwoD(5, 5, arr);
            for(int i = 0; i < 5; i++)
                for(int j = 0; j < 5; j++)
                    if (arr[i, j] < max && arr[i, j] > min) sum += arr[i, j];
            WriteLine($"Sum is: {sum}");
        }
        static void CaesarCipher()
        {

        }
    }
}
