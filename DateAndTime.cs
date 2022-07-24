
namespace DelegatesAndEvents
{
    public delegate T DateAndTimeDelegate<T>();
    public class DateAndTime
    {
        public string GetCurrentDateTime()
        {
            return DateTime.Now.ToString("g");
        }
        public string GetCurrentDate()
        {
            return DateTime.Today.ToString("d");
        }
        public string GetCurrentDayOfWeek()
        {
            return DateTime.Today.DayOfWeek.ToString();
        }
    }
}
