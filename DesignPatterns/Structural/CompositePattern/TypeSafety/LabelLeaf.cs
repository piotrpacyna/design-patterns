using DesignPatterns.Core;

namespace CompositePattern.TypeSafety
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
    }
}
