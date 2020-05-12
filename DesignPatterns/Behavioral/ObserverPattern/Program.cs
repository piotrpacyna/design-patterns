using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var forex = new CurrencyStockSubject("EUR", 1.23);
            forex.AddObserver(new Investor("Ted"));
            forex.AddObserver(new Investor("Mark"));

            forex.SetPrice(1.4);
            forex.SetPrice(2.2);

            Console.ReadLine();
        }
    }
}
