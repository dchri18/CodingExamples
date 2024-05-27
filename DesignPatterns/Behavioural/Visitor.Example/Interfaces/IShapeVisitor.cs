using Visitor.Example.Shapes;

namespace Visitor.Example.Interfaces
{
    public interface IShapeVisitor
    {
        void Visit(Circle circle);
        void Visit(Rectangle rectangle);
        void Visit(Triangle triangle);
    }
}
