
namespace ArraysStrings
{
    public partial class Procedures
    {
        public static string Cipher(int key, string? str)
        {
            string[] abc = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            int y, num;
            System.Text.StringBuilder cipher = new System.Text.StringBuilder("");
            for (int i = 0; i < str.Length; ++i)
            {
                string tmp = str[i].ToString();
                for (int j = 0; j <= 51; j++)
                {
                    if (tmp == abc[j])
                    {
                        num = j;
                        y = (num + key) % 52;
                        cipher.Insert(cipher.Length, abc[y]);
                    }
                }
            }
            return cipher.ToString();
        }
        public static string DeCipher(int key, string? str)
        {
            string[] abc = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            System.Text.StringBuilder deCipher = new System.Text.StringBuilder("");
            int y, num;
            for (int i = 0; i < str.Length; ++i)
            {
                string tmp = str[i].ToString();
                for (int j = 0; j <= 51; j++)
                {
                    if (tmp == abc[j])
                    {
                        num = j;
                        y = num - key;
                        if (y < 0) y += 52;
                        deCipher.Insert(deCipher.Length, abc[y]);
                    }
                }
            }
            return deCipher.ToString();
        }
        public static int MathOper(string exp)
        {
            string[] expression = exp.Split(' ');
            int res = 0;
            int first = Convert.ToInt32(expression[0]);
            string oper = Convert.ToString(expression[1]);
            int second = Convert.ToInt32(expression[2]);
            if (oper == "+") res = first + second;
            else if (oper == "-") res = first - second;
            else if (oper == "*") res = first * second;
            else if (oper == "/") res = first / second;
            else throw new Exception($"Invalid operation: {oper}");
            return res;
        }
        public static string LowerUpperCases(string text)
        {
            System.Text.StringBuilder newText = new System.Text.StringBuilder(text);
            newText[0] = Char.ToUpper(newText[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (newText[i] == '.')
                {
                    newText[i + 2] = Char.ToUpper(newText[i + 2]);
                    i++;
                }
                else throw new Exception("Your sentence is correct!");
            }
            return newText.ToString();
        }
        public static string CheckingText(string text, string word)
        {
            System.Text.StringBuilder newText = new System.Text.StringBuilder(text);
            System.Text.StringBuilder newWord = new System.Text.StringBuilder(word);
            int counter = 0;
            for (int i = 0; i < newText.Length; ++i)
            {
                for (int j = 0; j < newWord.Length; ++j)
                {
                    if (newText[i] == newWord[j])
                    {
                        counter++;
                        newText.Replace(newText[j], '*');
                    }
                    else throw new Exception("There isn`t forbidden words in your text!");
                }
            }
            return $" Your new text: {newText}\n Quantity of forbidden words: {counter}";
        }
    }
}
