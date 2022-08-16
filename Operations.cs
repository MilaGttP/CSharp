
namespace LINQToObject
{
    public static class Operations
    {
        public static string FirstPositiveLastNegative(this int[] sequency)
        {
            var posNums = from item in sequency where item > 0 select item;
            var negNums = from item in sequency where item < 0 select item;
            return $"{posNums.First()}, {negNums.Last()}";
        }
        public static int FirstPositiveInSequency(this int[] sequency, UInt32 number)
        {
            return sequency.FirstOrDefault(item => (item > 0) && (item % 10 == number));
        }
        public static string LastRowOfSequency(this string[] sequency, UInt32 number)
        {
            IEnumerable <string> fitNumberWords = from i in sequency let words = i.Split(' ', ';', ',')
                                                  from w in words where w.Count() == number select w;
            string digitWords = null;
            if (fitNumberWords != null)
            {
                foreach (string word in fitNumberWords)
                {
                    if (char.IsDigit(word[0]) == true)
                    {
                        int len = word.Length;
                        digitWords = $"{word[len - 5]}{word[len - 4]}{word[len - 3]}{word[len - 2]}{word[len - 1]}";
                    }
                }
                return digitWords;
            }
            else throw new Exception("Not found.");
        }
        public static IEnumerable <int> PositiveSequency(this int[] sequency)
        {
            var lastDigits = from number in sequency where number > 0 select number % 10;
            return lastDigits.Distinct();
        }
    }
}
