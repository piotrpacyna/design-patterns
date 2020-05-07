using DesignPatterns.Core;

namespace BridgePattern
{
    public class Circle : IShape
    {
        private readonly IDrawApi drawApi;

        public Circle(IDrawApi drawApi)
        {
            this.drawApi = drawApi;
        }

        public void Draw()
        {
            LogHelper.LogMethodCall(LogHelper.MethodType.Main, nameof(Draw), nameof(Circle));
            drawApi.Draw();
        }
    }
}
