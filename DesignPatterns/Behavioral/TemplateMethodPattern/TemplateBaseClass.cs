using DesignPatterns.Core;

namespace TemplateMethodPattern
{
    public abstract class TemplateBaseClass
    {
        public void TemplateMethod()
        {
            LogHelper.LogMethodCall(LogHelper.MethodType.Main, nameof(TemplateMethod), nameof(TemplateBaseClass));
            Method1();
            Method2();
            Method3();
            LogHelper.LogSeparator();
        }

        protected abstract void Method1();
        protected abstract void Method2();

        protected virtual void Method3()
        {
            LogHelper.LogMethodCall(LogHelper.MethodType.Virtual, nameof(Method3), nameof(TemplateBaseClass));
        }
    }
}
