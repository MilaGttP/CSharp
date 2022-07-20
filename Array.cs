
namespace DelegatesAndEvents
{
    public delegate T ArrayDelegate<T>();
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
        public string GetSimpleNumbers()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            foreach (int item in array)
                if ((item == 1) || (item / 1 == 0 && item / item == 0)) stringBuilder.Append(item);
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
