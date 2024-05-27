using Visitor.Example.Interfaces;
using Visitor.Example.Shapes;
using Visitor.Example.ShapeVisitors;

namespace Visitor.Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>
            {
                new Circle(5),
                new Rectangle(4, 6),
                new Triangle(3, 7)
            };

            AreaCalculator areaCalculator = new AreaCalculator();
            DrawingVisitor drawingVisitor = new DrawingVisitor();

            foreach (var shape in shapes)
            {
                shape.Accept(areaCalculator);
            }

            Console.WriteLine();

            foreach (var shape in shapes)
            {
                shape.Accept(drawingVisitor);
            }
        }
    }
}
