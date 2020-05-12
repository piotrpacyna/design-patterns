using System.Collections.Generic;
using DesignPatterns.Core;

namespace FlyweightPattern
{
    public class CoffeeFactory
    {
        private readonly Dictionary<string, CoffeeFlyweight> flyweights = new Dictionary<string, CoffeeFlyweight>();

        public CoffeeFlyweight GetFlyweight(string key)
        {
            string tempKey = key.ToLower();
            CoffeeFlyweight coffee = null;

            if (flyweights.ContainsKey(tempKey))
            {
                coffee = flyweights[tempKey];
                LogHelper.Log($"Coffee flyweight for key: {key} exists: {coffee.GetType().Name}");
            }
            else
            {
                switch (key.ToLower())
                {
                    case "a":
                        coffee = new AmericanoCoffee();
                        break;
                    case "e":
                        coffee = new EspressoCoffee();
                        break;
                    case "l":
                        coffee = new LatteCoffee();
                        break;
                }

                if (coffee != null)
                {
                    LogHelper.Log($"Coffee flyweight for key: {key} created: {coffee.GetType().Name}");
                    flyweights.Add(tempKey, coffee);
                }
            }

            return coffee;
        }
    }
}
