using DesignPatterns.Core;

namespace DecoratorPattern
{
    public class VerticalScrollBarDecorator : WindowDecorator
    {
        public VerticalScrollBarDecorator(WindowComponent component) : base(component)
        {
        }

        public override void Draw()
        {
            base.Draw();
            LogHelper.Log("- with vertical scroll bar");
        }
    }
}
