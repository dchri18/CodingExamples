namespace Visitor.Example.Interfaces
{
    public interface IShape
    {
        void Accept(IShapeVisitor visitor);
    }
}
