using DesignPatterns.Core;

namespace FlyweightPattern
{
    public class LatteCoffee : CoffeeFlyweight
    {
        public override void Print()
        {
            LogHelper.Log("Latte coffee");
        }
    }
}
