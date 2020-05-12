namespace IteratorPattern
{
    public class ItemIterator : IItemIterator
    {
        private readonly ItemCollection collection;
        private int currentIndex = -1;

        public ItemIterator(ItemCollection collection)
        {
            this.collection = collection;
        }

        public bool HasNext()
        {
            return currentIndex + 1 < collection.Count;
        }

        public Item Next()
        {
            if (HasNext())
            {
                currentIndex++;
                return collection[currentIndex];
            }

            return null;
        }
    }
}
