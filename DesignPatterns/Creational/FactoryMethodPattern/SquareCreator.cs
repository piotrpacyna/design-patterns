namespace FactoryMethodPattern
{
    public class SquareCreator : FigureCreator
    {
        public override Figure FactoryMethod()
        {
            return new Square();
        }
    }
}
