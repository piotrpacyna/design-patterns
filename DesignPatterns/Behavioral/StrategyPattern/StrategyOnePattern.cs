using DesignPatterns.Core;

namespace StrategyPattern
{
    public class StrategyOnePattern : IStrategyPattern
    {
        public void Method()
        {
            LogHelper.LogMethodCall(LogHelper.MethodType.Main, nameof(Method), nameof(StrategyOnePattern));
        }
    }
}
