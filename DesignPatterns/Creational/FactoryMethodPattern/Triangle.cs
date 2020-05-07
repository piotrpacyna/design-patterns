namespace FactoryMethodPattern
{
    public class Triangle : Figure
    {
        public override string GetName()
        {
            return nameof(Triangle);
        }
    }
}
