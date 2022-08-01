
namespace ExtensionMethods
{
    public static class Extensions
    {
        public static bool IsFibonacci(this int number)
        {
            if (Math.Sqrt(5 * (Math.Pow(number, 2)) - 4) % 1 == 0 || Math.Sqrt(5 * (Math.Pow(number, 2)) + 4) % 1 == 0)
                return true;
            else return false;
        }
        public static int WordsQuantity(this string str)
        {
            if (string.IsNullOrEmpty(str)) return 0;
            str = System.Text.RegularExpressions.Regex.Replace(str.Trim(), @"\s+", " ");
            return str.Split(' ').Length;
        }
        public static int LastWordLength(this string str)
        {
            if (string.IsNullOrEmpty(str)) return 0;
            return str.Split(' ').Last().Length;
        }
        public static bool IsValidString(this string str)
        {
            if (string.IsNullOrEmpty(str)) throw new ArgumentException("String is null or empty!");
            Stack<char> stack = new Stack <char> ();
            foreach (char item in str)
            {
                switch (item)
                {
                    case '(': stack.Push(')'); break;
                    case '[': stack.Push(']'); break;
                    case '{': stack.Push('}'); break;

                    case ')':
                    case ']':
                    case '}':
                        if (stack.Count == 0 || stack.Peek() != item) return false;
                        stack.Pop();
                        break;
                    default: break;
                }
            }
            return stack.Count == 0;
        }
        public static string FilterArray(this string origin, string forFilter)
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
            return original.Replace(" ", "").ToString();
        }
    }
}
