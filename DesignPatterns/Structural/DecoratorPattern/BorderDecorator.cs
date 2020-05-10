using DesignPatterns.Core;

namespace DecoratorPattern
{
    public class BorderDecorator : WindowDecorator
    {
        public BorderDecorator(WindowComponent component) : base(component)
        {
        }

        public override void Draw()
        {
            base.Draw();
            LogHelper.Log("- with border");
        }
    }
}
