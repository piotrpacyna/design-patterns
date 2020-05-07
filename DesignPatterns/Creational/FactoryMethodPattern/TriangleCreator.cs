namespace FactoryMethodPattern
{
    public class TriangleCreator : FigureCreator
    {
        public override Figure FactoryMethod()
        {
            return new Triangle();
        }
    }
}
