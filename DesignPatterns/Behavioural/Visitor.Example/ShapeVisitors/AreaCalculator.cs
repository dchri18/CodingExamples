using Visitor.Example.Interfaces;
using Visitor.Example.Shapes;

namespace Visitor.Example.ShapeVisitors
{
    public class AreaCalculator : IShapeVisitor
    {
        public void Visit(Circle circle)
        {
            double area = Math.PI * circle.Radius * circle.Radius;
            Console.WriteLine($"Area of Circle: {area}");
        }

        public void Visit(Rectangle rectangle)
        {
            double area = rectangle.Width * rectangle.Height;
            Console.WriteLine($"Area of Rectangle: {area}");
        }

        public void Visit(Triangle triangle)
        {
            double area = 0.5 * triangle.Base * triangle.Height;
            Console.WriteLine($"Area of Triangle: {area}");
        }
    }
}
