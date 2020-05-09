using DesignPatterns.Core;

namespace CompositePattern.Uniformity
{
    public class LabelLeaf : ControlComponent
    {
        public LabelLeaf(string name) : base(name)
        {
        }

        public override void Print(int depth)
        {
            LogHelper.Log($"{new string(DepthIndicator, depth)} {nameof(LabelLeaf)} - {Name}");
        }

        public override void Add(ControlComponent control)
        {
            LogHelper.Log($"Cannot add a control to {nameof(LabelLeaf)}.");
        }

        public override void Remove(ControlComponent control)
        {
            LogHelper.Log($"Cannot remove control from {nameof(LabelLeaf)}.");
        }
    }
}
