
namespace AnonMethodsAndLambda
{
    public delegate string ConvertColor (System.Drawing.Color color);
    public class Dispacher
    {
        public event ConvertColor colorEvent;
        public string ConvertColor(System.Drawing.Color color)
        {
            if (colorEvent != null) return colorEvent(color); 
            throw new NullReferenceException();
        }
    }
}
