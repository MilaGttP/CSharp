
namespace Interfaces
{
    interface ICalc
    {
        public int Less(int valueToCompare);
        public int Greater(int valueToCompare);
    }
    interface ICalc2
    {
        public int CountDistinct();
        public int EqualToValue(int valueToCompare);
    }
    interface IOutput2
    {
        // --- By task, I must make the void type methods, but I did ---
        // --- them string type for unit testing --- 
        //public void ShowEven();
        //public void ShowOdd();

        public string ShowEven();
        public string ShowOdd();
    }
}