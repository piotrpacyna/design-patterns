using DesignPatterns.Core;

namespace StrategyPattern
{
    public class Context
    {
        private readonly IStrategyPattern strategy;

        public Context(IStrategyPattern strategy)
        {
            this.strategy = strategy;
        }

        public void CallStrategy()
        {
            LogHelper.LogMethodCall(LogHelper.MethodType.Main, nameof(CallStrategy), nameof(Context));
            strategy.Method();
            LogHelper.LogSeparator();
        }
    }
}
