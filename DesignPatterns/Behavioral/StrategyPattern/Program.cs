using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var strategyOne = new StrategyOnePattern();
            var strategyTwo = new StrategyTwoPattern();

            var contextOne = new Context(strategyOne);
            var contextTwo = new Context(strategyTwo);

            contextOne.CallStrategy();
            contextTwo.CallStrategy();

            Console.ReadLine();
        }
    }
}
