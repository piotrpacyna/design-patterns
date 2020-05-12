using DesignPatterns.Core;

namespace VisitorPattern
{
    public class SecondVisitor : IVisitor
    {
        public void VisitFirstElement(FirstElement element)
        {
            LogHelper.Log($"{element.GetType().Name} visited by {nameof(SecondVisitor)}");
        }

        public void VisitSecondElement(SecondElement element)
        {
            LogHelper.Log($"{element.GetType().Name} visited by {nameof(SecondVisitor)}");
        }
    }
}
