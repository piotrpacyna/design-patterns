namespace MementoPattern
{
    public class ProductMemento
    {
        public string Name { get; }
        public double Price { get; }

        public ProductMemento(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
