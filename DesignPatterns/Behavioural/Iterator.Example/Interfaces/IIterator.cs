namespace Iterator.Example.Interfaces
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}
