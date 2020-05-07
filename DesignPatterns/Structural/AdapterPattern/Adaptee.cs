using DesignPatterns.Core;

namespace AdapterPattern
{
    public class Adaptee
    {
        public void Request()
        {
            LogHelper.LogMethodCall(LogHelper.MethodType.Main, nameof(Request), nameof(Adaptee));
        }
    }
}
