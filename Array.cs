
namespace DelegatesAndEvents
{
    public delegate string ArrayDelegate ();
    public class Array
    {
        private int[] array { get; set; }
        public Array() { array = new int[0]; }
        public Array(int size) { array = new int[size]; }
        public Array(int[] arr) { array = arr; }
        public string GetEven()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            foreach (int item in array)
                if (item % 2 == 0) stringBuilder.Append(item);
            return stringBuilder.ToString();
        }
        public string GetOdd()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            foreach (int item in array)
                if (item % 2 != 0) stringBuilder.Append(item);
            return stringBuilder.ToString();
        }
        public static Boolean CheckOnePrime(int number)
        {
            for (int i = 2; i * i <= number; i++)
                if (number % i == 0)
                    return false;
            if (number == 0 || number == 1) return false;
            return true;
        }
        public string GetPrimeNumbers()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            foreach (var item in array)
                if (CheckOnePrime(item)) stringBuilder.Append(item);
            return stringBuilder.ToString();
        }
        public string GetFibonacci()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            foreach (int item in array)
                if (Math.Sqrt(5 * (Math.Pow(item, 2)) - 4) % 1 == 0 || Math.Sqrt(5 * (Math.Pow(item, 2)) + 4) % 1 == 0) 
                    stringBuilder.Append(item);
            return stringBuilder.ToString();
        }
    }
}