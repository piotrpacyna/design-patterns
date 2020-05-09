using DesignPatterns.Core;

namespace CompositePattern.TypeSafety
{
    public class ButtonLeaf : ControlComponent
    {
        public ButtonLeaf(string name) : base(name)
        {
        }

        public override void Print(int depth)
        {
            LogHelper.Log($"{new string(DepthIndicator, depth)} {nameof(ButtonLeaf)} - {Name}");
        }
    }
}
