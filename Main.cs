
namespace FileOperations
{
    public partial class Test
    {
        public static void LabTesting()
        {
            PrimeAndFibonacciNumbersTest();
            ReplaceWordsInFileTest();
            ModerateTextTest();
            TurnOverTextTest();
            BigFileStatTest();

        }
        public static void HWTesting()
        {
            SearchByMaskTest();
            DeleteByMaskTest();
            DeleteSubDirectoriesTest();
            ShowAllByPathTest();
        }
        public static void Main()
        {
            LabTesting();
            HWTesting();
        }
    }
}
