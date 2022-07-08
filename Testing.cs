
using static System.Console;

namespace ArraysStrings
{
    public partial class Procedures
    {
        static void ABArraysTest()
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
        static void TwoDimensional5On5Test()
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
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    if (arr[i, j] < max && arr[i, j] > min) sum += arr[i, j];
            WriteLine($"Sum is: {sum}");
        }
        static void CaesarCipherTest()
        {
            string wordToCipher, wordToDeCipher; int keyToCipher, keyToDeCipher;
            Write("Enter a word to cipher -> "); wordToCipher = Convert.ToString(ReadLine());
            Write("Enter a key -> "); keyToCipher = Convert.ToInt32(ReadLine());
            WriteLine($"Your word before cipher: {wordToCipher} , Your key: {keyToCipher}");
            WriteLine($"Your word after cipher: {Cipher(keyToCipher, wordToCipher)}");
            Write("Enter a word to decipher -> "); wordToDeCipher = Convert.ToString(ReadLine());
            Write("Enter a key -> "); keyToDeCipher = Convert.ToInt32(ReadLine());
            WriteLine($"Your word before decipher: {wordToDeCipher} , Your key: {keyToDeCipher}");
            WriteLine($"Your word after decipher: {DeCipher(keyToDeCipher, wordToDeCipher)}");
        }
        static void MatrixOperationsTest()
        {
            int[,] firstMatrix = new int[5, 5];
            int[,] secondMatrix = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    firstMatrix[i, j] = random.Next(1, 20);
            WriteLine("Your first matrix:  ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    Write($" {firstMatrix[i, j]}");
                WriteLine();
            }
            WriteLine();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    secondMatrix[i, j] = random.Next(1, 20);
            WriteLine("Your second matrix:  ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    Write($" {secondMatrix[i, j]}");
                WriteLine();
            }
            WriteLine();
            Write("What do you want to do with this?\n 1 - Multiply matrix on number\n 2 - Sum two matrixes\n 3 - Multiply two matrixes\n Enter -> ");
            int tmp = Convert.ToInt32(ReadLine());
            switch (tmp)
            {
                case 1:
                    Write("Enter number -> "); int num = Convert.ToInt32(ReadLine());
                    WriteLine($"Result of multiplying: {MultMatrixOnNum(num, firstMatrix)}");
                    break;
                case 2:
                    WriteLine($"Result of summing: {MatrixSum(firstMatrix, secondMatrix)}");
                    break;
                case 3:
                    WriteLine($"Result of multiplying: {MatrixMultiply(firstMatrix, secondMatrix)}");
                    break;
                default:
                    break;
            }
        }
        static void MathOperationsTest()
        {
            Write("Enter your expression -> ");
            string expression = Convert.ToString(ReadLine());
            Write($"Result: {MathOper(expression)}");
        }
        static void LowerUpperCasesTest()
        {
            Write("Enter your sentences -> ");
            string text = Convert.ToString(ReadLine());
            WriteLine($"Your new sentences: {LowerUpperCases(text)}");
        }
        static void CheckingTextTest()
        {
            Write("Enter your text -> "); string text = Convert.ToString(ReadLine());
            Write("Enter a forbidden word -> "); string word = Convert.ToString(ReadLine());
            WriteLine(CheckingText(text, word));
        }
    }
}
