using DesignPatterns.Core;

namespace DecoratorPattern
{
    public class FormComponent : WindowComponent
    {
        public override void Draw()
        {
            LogHelper.Log("Form");
        }
    }
}
