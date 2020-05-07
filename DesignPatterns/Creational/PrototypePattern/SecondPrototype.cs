using DesignPatterns.Core;

namespace PrototypePattern
{
    public class SecondPrototype : Prototype
    {
        private readonly string value;

        public SecondPrototype(string value)
        {
            this.value = value;
        }

        public override Prototype Clone()
        {
            LogHelper.Log($"Cloned: {nameof(SecondPrototype)}");
            return MemberwiseClone() as Prototype;
        }

        public override void Print()
        {
            LogHelper.Log($"Value: {value}");
        }
    }
}
