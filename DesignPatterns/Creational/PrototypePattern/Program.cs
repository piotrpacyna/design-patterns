using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPrototype = new FirstPrototype(1);
            var secondPrototype = new SecondPrototype("test");

            var firstClone = firstPrototype.Clone() as FirstPrototype;
            var secondClone = secondPrototype.Clone() as SecondPrototype;

            firstClone?.Print();
            secondClone?.Print();

            Console.ReadLine();
        }
    }
}
