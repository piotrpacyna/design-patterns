namespace DecoratorPattern
{
    public abstract class WindowDecorator : WindowComponent
    {
        protected readonly WindowComponent Component;

        protected WindowDecorator(WindowComponent component)
        {
            Component = component;
        }

        public override void Draw()
        {
            Component.Draw();
        }
    }
}
