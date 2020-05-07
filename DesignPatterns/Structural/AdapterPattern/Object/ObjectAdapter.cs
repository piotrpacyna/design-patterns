using DesignPatterns.Core;

namespace AdapterPattern.Object
{
    public class ObjectAdapter : ITarget
    {
        private Adaptee adaptee = new Adaptee();

        public void Convert()
        {
            LogHelper.LogMethodCall(LogHelper.MethodType.Main, nameof(Convert), nameof(ObjectAdapter));
            adaptee.Request();
        }
    }
}
