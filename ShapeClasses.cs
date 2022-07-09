
namespace AbsClasses
{
    public partial class AbstractClasses
    {
        public abstract class Shape
        {
            public double Square { get; set; }
            public double Width { get; set; }
            public double Length { get; set; }
            public double Height { get; set;}
            public double Radius { get; set; }
            public string Type { get; set; }
            public Shape()
            {
                Square = 0; Width = 0;
                Length = 0; Height = 0; 
                Radius = 0; Type = null;
            }
            public Shape(double width, double length)
            {
                Width = width; Length = length;
            }
            public Shape(double width, double length, double height)
            {
                Width = width; Length = length; Height = height;
            }
            public Shape(double radius)
            {
                Radius = radius;
            }
            public void EnterWidthLength()
            {
                Console.Write($"Enter {Type} width -> "); Width = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Enter {Type} length -> "); Length = Convert.ToDouble(Console.ReadLine());
            }
            public void EnterWidthLengthHeight()
            {
                Console.Write($"Enter {Type} width -> "); Width = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Enter {Type} length -> "); Length = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Enter {Type} height -> "); Height = Convert.ToDouble(Console.ReadLine());
            }
            public void EnterRadius()
            {
                Console.Write($"Enter {Type} radius -> "); Radius = Convert.ToDouble(Console.ReadLine());
            }
            public abstract double SearchSquare();
        }
        public class Rectangle : Shape
        {
            public Rectangle() : base() { Type = "rectangle"; }
            public Rectangle(double width, double length) : base(width, length) { }
            public override double SearchSquare()
            {
                Square = Width * Length;
                return Square;
            }
        }
        public class Circle : Shape
        {
            public Circle() : base() { Type = "circle"; }
            public Circle(double radius) : base(radius) { }
            public override double SearchSquare()
            {
                Square = 3.14 * Math.Pow(Radius, 2);
                return Square;
            }
        }
        public class RectangularTriangle : Shape
        {
            public RectangularTriangle() : base() { Type = "rectangular triangle"; }
            public RectangularTriangle(double width, double length) : base(width, length) { }
            public override double SearchSquare()
            {
                Square = (Width * Length) / 2;
                return Square;
            }
        }
        public class Trapeze : Shape
        {
            public Trapeze() : base() { Type = "trapeze"; }
            public Trapeze(double width, double length, double height) : base(width, length, height) { }
            public override double SearchSquare()
            {
                Square = Height * (Width * Length) / 2;
                return Square;
            }
        }
    }
}
