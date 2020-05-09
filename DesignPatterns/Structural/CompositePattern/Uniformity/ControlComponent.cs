namespace CompositePattern.Uniformity
{
    public abstract class ControlComponent
    {
        protected string Name { get; }
        protected char DepthIndicator { get; } = '-';

        protected ControlComponent(string name)
        {
            Name = name;
        }

        public abstract void Print(int depth);
        public abstract void Add(ControlComponent control);
        public abstract void Remove(ControlComponent control);
    }
}
