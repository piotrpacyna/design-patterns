using DesignPatterns.Core;

namespace FlyweightPattern
{
    public class EspressoCoffee : CoffeeFlyweight
    {
        public override void Print()
        {
            LogHelper.Log("Espresso coffee");
        }
    }
}
