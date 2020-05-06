using DesignPatterns.Core;

namespace TemplateMethodPattern
{
    public class TemplateOneClass : TemplateBaseClass
    {
        protected override void Method1()
        {
            LogHelper.LogMethodCall(LogHelper.MethodType.Abstract, nameof(Method1), nameof(TemplateOneClass));
        }

        protected override void Method2()
        {
            LogHelper.LogMethodCall(LogHelper.MethodType.Abstract, nameof(Method2), nameof(TemplateOneClass));
        }
    }
}
