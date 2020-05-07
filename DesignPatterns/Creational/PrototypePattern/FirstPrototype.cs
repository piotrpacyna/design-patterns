using DesignPatterns.Core;

namespace PrototypePattern
{
    public class FirstPrototype : Prototype
    {
        private readonly int value;


        public FirstPrototype(int value)
        {
            this.value = value;
        }

        public override Prototype Clone()
        {
            LogHelper.Log($"Cloned: {nameof(FirstPrototype)}");
            return MemberwiseClone() as Prototype;
        }

        public override void Print()
        {
            LogHelper.Log($"Value: {value}");
        }
    }
}
