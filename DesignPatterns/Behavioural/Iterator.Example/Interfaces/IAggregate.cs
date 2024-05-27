namespace Iterator.Example.Interfaces
{
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }
}
