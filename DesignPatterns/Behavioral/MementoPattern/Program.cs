using System;
using DesignPatterns.Core;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new ProductOriginator("Test", 1);
            product.Log();
            LogHelper.LogSeparator();
            var memento = new ProductCareTaker
            {
                Memento = product.CreateMemento()
            };
            LogHelper.LogSeparator();
            product.SetName("New name");
            product.SetPrice(2);
            LogHelper.LogSeparator();
            product.Log();
            LogHelper.LogSeparator();
            product.RestoreMemento(memento.Memento);
            LogHelper.LogSeparator();
            product.Log();

            Console.ReadLine();
        }
    }
}
