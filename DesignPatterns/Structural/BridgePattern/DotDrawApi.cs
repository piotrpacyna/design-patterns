using DesignPatterns.Core;

namespace BridgePattern
{
    public class DotDrawApi : IDrawApi
    {
        public void Draw()
        {
            LogHelper.LogMethodCall(LogHelper.MethodType.Main, nameof(Draw), nameof(DotDrawApi));
            LogHelper.Log(new string('.', 30));
        }
    }
}
