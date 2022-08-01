
namespace Records
{
    public record DayTemperature (double minDayTemperature, double maxDayTemperature);
    public record Marks (int history, int math, int english);
    public class ForRecords
    {
        public double MaxTemperatureDifference (DayTemperature first, DayTemperature second, DayTemperature third)
        {
            double firstDiff = first.maxDayTemperature - first.minDayTemperature;
            double secondDiff = second.maxDayTemperature - second.minDayTemperature;
            double thirdDiff = third.maxDayTemperature - third.minDayTemperature;
            double[] diffs = { firstDiff, secondDiff, thirdDiff }; Array.Sort(diffs);
            return diffs[2];
        }
        public int MaxMediumMark(Marks first, Marks second, Marks third)
        {
            int firstAvg = (first.history + first.math + first.english) / 3;
            int secondAvg = (second.history + second.math + second.english) / 3;
            int thirdAvg = (third.history + third.math + third.english) / 3;
            int[] avg = { firstAvg, secondAvg, thirdAvg }; Array.Sort(avg);
            return avg[2];
        }
        public int AverageMediumMark(Marks first, Marks second, Marks third)
        {
            int firstAvg = (first.history + first.math + first.english) / 3;
            int secondAvg = (second.history + second.math + second.english) / 3;
            int thirdAvg = (third.history + third.math + third.english) / 3;
            int[] avg = { firstAvg, secondAvg, thirdAvg }; Array.Sort(avg);
            return avg[1];
        }
    }
}
