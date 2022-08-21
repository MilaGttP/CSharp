
using System.Text.RegularExpressions;

namespace FileOperations
{
    public partial class LabOperations
    {
        public static bool IsPrime(int number)
        {
            for (int i = 2; i * i <= number; i++)
                if (number % i == 0)
                    return false;
            if (number == 0 || number == 1) return false;
            return true;
        }
        public static int[] FillArray(int size)
        {
            int[] array = new int[size];  
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(-10000, 10000);
            return array;
        }
        public static string PrimeAndFibonacciNumbers()
        {
            int[] numbers = new int[100];
            numbers = FillArray(numbers.Length);
            List<int> primeNumbers = new List<int>();
            List<int> fibonacciNumbers = new List<int>();
            foreach (int item in numbers)
            {
                if (IsPrime(item) == true) primeNumbers.Add(item);
                if (Math.Sqrt(5 * Math.Pow(item, 2) - 4) % 1 == 0 || Math.Sqrt(5 * Math.Pow(item, 2) + 4) % 1 == 0)
                    fibonacciNumbers.Add(item);
            }
            string primes = string.Join(" ", primeNumbers.ToArray());
            string fibonaccis = string.Join(" ", fibonacciNumbers.ToArray());
            FileOperation.WriteFile("prime.bin", primes);
            FileOperation.WriteFile("fibonacci.bin", fibonaccis);
            return $"{primeNumbers.ToArray().Length} prime and {fibonacciNumbers.ToArray().Length} fibonacci numbers were recorded!";
        }
        public static void ReplaceWordsInFile(string toReplace, string onReplace, string fileName)
        {
            string fromFile = FileOperation.ReadFile(fileName);
            if (fromFile.Contains(toReplace))
            {
                string buffer = Regex.Replace(fromFile, toReplace, onReplace);
                FileOperation.WriteFile(fileName, buffer);
            }
            else throw new Exception("There isn`t such a words to replace!");
        }
        public static void ModerateText(string fileNameForMod, string fileNameWithWords)
        {
            string buffForMod = FileOperation.ReadFile(fileNameForMod);
            string buffWithWords = FileOperation.ReadFile(fileNameWithWords);
            if (buffForMod.Contains(buffWithWords))
            {
                string newBuffer = Regex.Replace(buffForMod, buffWithWords, "***");
                FileOperation.WriteFile(fileNameForMod, newBuffer);
            }
            else throw new Exception("There isn`t such a words to moderate!");
        }
        public static void TurnOverText(string oldPath, string newPath)
        {
            string fromfile = FileOperation.ReadFile(oldPath);
            char[] toFileCharArr = fromfile.ToCharArray();
            string toFile = String.Empty;
            for (int i = toFileCharArr.Length - 1; i > -1; i--)
                toFile += toFileCharArr[i];
            FileOperation.WriteFile(newPath, toFile);
        }
        public static string BigFileStat(string path)
        {
            // --- made a file with 10000 numbers ---
            //int[] numbers = new int[10000];
            //numbers = FillArray(numbers.Length);
            //string numbersToFile = string.Join(" ", numbers.ToArray());
            //FileOperation.WriteFile("manyNumbers.bin", numbersToFile);

            List<int> numbersFromFile = new List<int>();
            List<int> positiveNumbers = new List<int>();
            List<int> negativeNumbers = new List<int>();
            List<int> twoDigitNumbers = new List<int>();
            List<int> fiveDigitNumbers = new List<int>();

            string fromFile = FileOperation.ReadFile(path);
            foreach (var item in fromFile)
                numbersFromFile.Add(item);
            foreach (int item in numbersFromFile)
            {
                if (item > 0) positiveNumbers.Add(item);
                if (item < 0) negativeNumbers.Add(item);
                if (item.ToString().Length == 2) twoDigitNumbers.Add(item);
                else if (item.ToString().Length == 5) fiveDigitNumbers.Add(item);
            }
            string positives = string.Join(" ", positiveNumbers.ToArray());
            string negatives = string.Join(" ", negativeNumbers.ToArray());
            string twoDigits = string.Join(" ", twoDigitNumbers.ToArray());
            string fiveDigits = string.Join(" ", fiveDigitNumbers.ToArray());
            FileOperation.WriteFile("positive.bin", positives);
            FileOperation.WriteFile("negative.bin", negatives);
            FileOperation.WriteFile("twoDigit.bin", twoDigits);
            FileOperation.WriteFile("fiveDigit.bin", fiveDigits);
            return $" Was recorded: \n {positiveNumbers.ToArray().Length} positives, \n {negativeNumbers.ToArray().Length} negatives, \n " +
                $"{twoDigitNumbers.ToArray().Length} two - digits, \n {fiveDigitNumbers.ToArray().Length} five - digits \n";
        }
    }
}
