using Visitor.Example.Interfaces;
using Visitor.Example.Shapes;

namespace Visitor.Example.ShapeVisitors
{
    public class DrawingVisitor : IShapeVisitor
    {
        public void Visit(Circle circle)
        {
            Console.WriteLine("Drawing Circle");
        }

        public void Visit(Rectangle rectangle)
        {
            Console.WriteLine("Drawing Rectangle");
        }

        public void Visit(Triangle triangle)
        {
            Console.WriteLine("Drawing Triangle");
        }
    }
}
