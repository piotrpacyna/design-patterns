using DesignPatterns.Core;

namespace FlyweightPattern
{
    public class AmericanoCoffee : CoffeeFlyweight
    {
        public override void Print()
        {
            LogHelper.Log("Americano coffee");
        }
    }
}
