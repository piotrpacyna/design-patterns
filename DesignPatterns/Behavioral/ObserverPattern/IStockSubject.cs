namespace ObserverPattern
{
    public interface IStockSubject
    {
        string Currency { get; }
        double Price { get; }

        void AddObserver(IStockObserver observer);
        void RemoveObserver(IStockObserver observer);
        void Notify();
        void SetPrice(double price);
    }
}
