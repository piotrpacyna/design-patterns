using DesignPatterns.Core;
using System.Collections.Generic;

namespace CompositePattern.Uniformity
{
    public class FormComposite : ControlComponent
    {
        private readonly List<ControlComponent> components = new List<ControlComponent>();

        public FormComposite(string name) : base(name)
        {
        }

        public override void Print(int depth)
        {
            LogHelper.Log($"{new string(DepthIndicator, depth)} {nameof(FormComposite)} - {Name}");

            foreach (var component in components)
            {
                component.Print(depth + 2);
            }
        }

        public override void Add(ControlComponent control)
        {
            components.Add(control);
        }

        public override void Remove(ControlComponent control)
        {
            components.Remove(control);
        }
    }
}
