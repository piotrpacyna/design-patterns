namespace VisitorPattern
{
    public class FirstElement : Element
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitFirstElement(this);
        }
    }
}
