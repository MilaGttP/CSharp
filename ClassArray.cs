
namespace Interfaces
{
    public class Array : ICalc, ICalc2, IOutput2
    {
        private int[] array { get; set; }
        int counter;
        public Array()
        {
            array = new int[0];
            counter = 0;
        }
        public Array(int[] arr)
        {
            array = arr;
            counter = 0;
        }
        public int Less(int valueToCompare)
        {
            foreach (int item in array)
                if (item < valueToCompare) counter++;
            return counter;
        }
        public int Greater(int valueToCompare)
        {
            foreach (int item in array)
                if (item > valueToCompare) counter++;
            return counter;
        }
        public int CountDistinct()
        {
            return counter = array.Where(t => array.Count(t.Equals) == 1).Count();
        }
        public int EqualToValue(int valueToCompare)
        {
            foreach (int item in array)
                if (item == valueToCompare) counter++;
            return counter;
        }
        public string ShowEven()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            foreach (int item in array)
                if (item % 2 == 0) stringBuilder.Append(item);
            return stringBuilder.ToString();
        }
        public string ShowOdd()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            foreach (int item in array)
                if (item % 2 != 0) stringBuilder.Append(item);
            return stringBuilder.ToString();
        }
    }
}
