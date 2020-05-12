namespace IteratorPattern
{
    public interface IAggregateCollection
    {
        IItemIterator CreateIterator();
    }
}
