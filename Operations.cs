
namespace DLLOperations
{
    public class Operations
    {
        public static double GetMonitorDiagonal()
        {
            string displayWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
            string displayHeight = Screen.PrimaryScreen.Bounds.Height.ToString();
            return Math.Sqrt(Math.Pow(Convert.ToDouble(displayWidth), 2) + Math.Pow(Convert.ToDouble(displayHeight), 2)) / 96;
        }
    }
}
