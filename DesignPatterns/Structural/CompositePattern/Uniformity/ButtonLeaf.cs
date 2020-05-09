using DesignPatterns.Core;

namespace CompositePattern.Uniformity
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

        public override void Add(ControlComponent control)
        {
            LogHelper.Log($"Cannot add a control to {nameof(ButtonLeaf)}.");
        }

        public override void Remove(ControlComponent control)
        {
            LogHelper.Log($"Cannot remove control from {nameof(ButtonLeaf)}.");
        }
    }
}
