using System.Collections.Generic;

namespace ObserverPattern
{
    public class CurrencyStockSubject : IStockSubject
    {
        private readonly List<IStockObserver> investors = new List<IStockObserver>();

        public string Currency { get; }
        public double Price { get; private set; }

        public CurrencyStockSubject(string currency, double price)
        {
            Currency = currency;
            Price = price;
        }

        public void AddObserver(IStockObserver observer)
        {
            investors.Add(observer);
        }

        public void RemoveObserver(IStockObserver observer)
        {
            investors.Remove(observer);
        }

        public void Notify()
        {
            investors.ForEach(x => x.Update(this));
        }

        public void SetPrice(double price)
        {
            Price = price;
            Notify();
        }
    }
}
