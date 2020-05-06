using DesignPatterns.Core;

namespace TemplateMethodPattern
{
    public class TemplateTwoClass : TemplateBaseClass
    {
        protected override void Method1()
        {
            LogHelper.LogMethodCall(LogHelper.MethodType.Abstract, nameof(Method1), nameof(TemplateTwoClass));
        }

        protected override void Method2()
        {
            LogHelper.LogMethodCall(LogHelper.MethodType.Abstract, nameof(Method2), nameof(TemplateTwoClass));
        }

        protected override void Method3()
        {
            LogHelper.LogMethodCall(LogHelper.MethodType.Overridden, nameof(Method3), nameof(TemplateTwoClass));
        }
    }
}
