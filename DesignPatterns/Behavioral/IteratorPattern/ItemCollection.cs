using System.Collections.Generic;

namespace IteratorPattern
{
    public class ItemCollection : IAggregateCollection
    {
        private readonly List<Item> list = new List<Item>();

        public int Count => list.Count;

        public Item this[int index]
        {
            get => list[index];
            set => list.Insert(index, value);
        }

        public IItemIterator CreateIterator()
        {
            return new ItemIterator(this);
        }
    }
}
