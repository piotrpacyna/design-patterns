using DesignPatterns.Core;

namespace ObserverPattern
{
    public class Investor : IStockObserver
    {
        private readonly string name;

        public Investor(string name)
        {
            this.name = name;
        }

        public void Update(IStockSubject subject)
        {
            LogHelper.Log($"Investor: {name} has been notified about change {subject.Currency} currency to: {subject.Price:C2}");
        }
    }
}
