using DesignPatterns.Core;

namespace BridgePattern
{
    public class DashDrawApi : IDrawApi
    {
        public void Draw()
        {
            LogHelper.LogMethodCall(LogHelper.MethodType.Main, nameof(Draw), nameof(DashDrawApi));
            LogHelper.Log(new string('-', 30));
        }
    }
}
