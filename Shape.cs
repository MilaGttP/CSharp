
namespace DelegatesAndEvents
{
    public delegate double ShapeDelegate(double value1, double value2);
    public class Shape
    {
        public double GetTriangleSquare(double side, double height)
        {
            return 0.5 * side * height;
        }
        public double GetRectangleSquare(double width, double length)
        {
            return width * length;
        }
    }
}