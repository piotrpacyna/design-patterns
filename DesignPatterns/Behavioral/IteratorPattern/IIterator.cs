namespace IteratorPattern
{
    public interface IItemIterator
    {
        bool HasNext();
        Item Next();
    }
}
