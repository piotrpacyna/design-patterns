using DesignPatterns.Core;

namespace DecoratorPattern
{
    public class HorizontalScrollBarDecorator : WindowDecorator
    {
        public HorizontalScrollBarDecorator(WindowComponent component) : base(component)
        {
        }

        public override void Draw()
        {
            base.Draw();
            LogHelper.Log("- with horizontal scroll bar");
        }
    }
}
