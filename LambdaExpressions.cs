
namespace AnonMethodsAndLambda
{
    public class LambdaExpressions
    {
        public int MultipleOfSeven (int[] arr)
        {
            return arr.Count(n => n % 7 == 0);
        }
        public int PositiveInArr(int[] arr)
        {
            return arr.Count(n => n > 0);
        }
        public int NegativeInArr(int[] arr)
        {
            return arr.Count(n => n < 0);
        }
        public bool FindWord(string[] text, string word)
        {
            if (text.Where(x => x.StartsWith(word)).FirstOrDefault() == word) return true;
            else return false;
        }
    }
}
