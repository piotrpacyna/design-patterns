using DesignPatterns.Core;
using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new ItemCollection
            {
                [0] = new Item("1"),
                [1] = new Item("3"),
                [2] = new Item("123"),
                [3] = new Item("999")
            };

            var iterator = collection.CreateIterator();

            while (iterator.HasNext())
            {
                var item = iterator.Next();
                LogHelper.Log($"Item: {item.Name}");
            }

            Console.ReadLine();
        }
    }
}
