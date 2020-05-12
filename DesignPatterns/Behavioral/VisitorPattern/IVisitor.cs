namespace VisitorPattern
{
    public interface IVisitor
    {
        void VisitFirstElement(FirstElement element);
        void VisitSecondElement(SecondElement element);
    }
}
