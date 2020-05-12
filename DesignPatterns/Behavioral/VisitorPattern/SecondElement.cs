namespace VisitorPattern
{
    public class SecondElement : Element
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitSecondElement(this);
        }
    }
}
