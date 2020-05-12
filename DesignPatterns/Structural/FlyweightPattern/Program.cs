using System;
using System.Linq;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeFactory factory = new CoffeeFactory();
            var orders = "AeLaAlEAaLle";

            foreach (var order in orders.Select(x => x.ToString()))
            {
                var coffee = factory.GetFlyweight(order);
                coffee.Print();
            }

            Console.ReadLine();
        }
    }
}
