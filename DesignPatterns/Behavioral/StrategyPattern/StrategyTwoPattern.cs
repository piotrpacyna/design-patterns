using DesignPatterns.Core;

namespace StrategyPattern
{
    public class StrategyTwoPattern : IStrategyPattern
    {
        public void Method()
        {
            LogHelper.LogMethodCall(LogHelper.MethodType.Main, nameof(Method), nameof(StrategyTwoPattern));
        }
    }
}
