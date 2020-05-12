namespace ObserverPattern
{
    public interface IStockObserver
    {
        void Update(IStockSubject subject);
    }
}
