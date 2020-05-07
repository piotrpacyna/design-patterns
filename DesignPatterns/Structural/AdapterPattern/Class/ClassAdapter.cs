using DesignPatterns.Core;

namespace AdapterPattern.Class
{
    public class ClassAdapter : Adaptee, ITarget
    {
        public void Convert()
        {
            LogHelper.LogMethodCall(LogHelper.MethodType.Main, nameof(Convert), nameof(ClassAdapter));
            Request();
        }
    }
}
