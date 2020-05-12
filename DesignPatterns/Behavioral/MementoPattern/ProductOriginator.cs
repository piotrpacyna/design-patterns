using DesignPatterns.Core;

namespace MementoPattern
{
    public class ProductOriginator
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public ProductOriginator(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public void SetPrice(double price)
        {
            LogHelper.Log($"Changing price from: '{Price}' to: '{price}'");
            Price = price;
        }

        public void SetName(string name)
        {
            LogHelper.Log($"Changing name from: '{Name}' to: '{name}'");
            Name = name;
        }

        public ProductMemento CreateMemento()
        {
            LogHelper.Log($"Creating memento for: {Name}; {Price}");
            return new ProductMemento(Name, Price);
        }

        public void RestoreMemento(ProductMemento memento)
        {
            LogHelper.Log($"Restoring from memento: {memento.Name}; {memento.Price}");
            Name = memento.Name;
            Price = memento.Price;
        }

        public void Log()
        {
            LogHelper.Log($"Current state: {Name}; {Price}");
        }
    }
}
