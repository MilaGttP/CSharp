﻿
using static System.Console;

namespace FileOperations
{
    public partial class Test
    {
        // *-------- LAB -------------*
        public static void PrimeAndFibonacciNumbersTest()
        {
            WriteLine(LabOperations.PrimeAndFibonacciNumbers());
        }
        public static void ReplaceWordsInFileTest()
        {
            Write("Enter a to replace word -> "); string toReplace = ReadLine();
            Write("Enter a word on which replace -> "); string onReplace = ReadLine();
            Write("Enter a file name -> "); string fileName = ReadLine();
            WriteLine(" --- File before replacing words --- ");
            WriteLine(FileOperation.ReadFile(fileName));
            LabOperations.ReplaceWordsInFile(toReplace, onReplace, fileName);
            WriteLine(" --- File after replacing words --- ");
            WriteLine(FileOperation.ReadFile(fileName));
        }
        public static void ModerateTextTest()
        {
            Write("Enter a file name for moderate -> "); string fileNameForMod = ReadLine();
            Write("Enter a file name with words for moderating -> "); string fileNameWithWords = ReadLine();
            WriteLine(" --- File before moderating words --- ");
            WriteLine(FileOperation.ReadFile(fileNameForMod));
            LabOperations.ModerateText(fileNameForMod, fileNameWithWords);
            WriteLine(" --- File after moderating words --- ");
            WriteLine(FileOperation.ReadFile(fileNameForMod));
        }
        public static void TurnOverTextTest()
        {
            Write("Enter a file name of old text -> "); string oldName = ReadLine();
            Write("Enter a file name for new text -> "); string newName = ReadLine();
            WriteLine(" --- Old file --- ");
            WriteLine(FileOperation.ReadFile(oldName));
            LabOperations.TurnOverText(oldName, newName);
            WriteLine(" --- New file --- ");
            WriteLine(FileOperation.ReadFile(newName));
        }
        public static void BigFileStatTest()
        {
            Write("Enter a file name -> "); string path = ReadLine();
            WriteLine(LabOperations.BigFileStat(path));
        }

        // *-------- HW -------------*

    }
}
