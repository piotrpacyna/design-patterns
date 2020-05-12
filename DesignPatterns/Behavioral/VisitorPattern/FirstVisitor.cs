using DesignPatterns.Core;

namespace VisitorPattern
{
    public class FirstVisitor : IVisitor
    {
        public void VisitFirstElement(FirstElement element)
        {
            LogHelper.Log($"{element.GetType().Name} visited by {nameof(FirstVisitor)}");
        }

        public void VisitSecondElement(SecondElement element)
        {
            LogHelper.Log($"{element.GetType().Name} visited by {nameof(FirstVisitor)}");
        }
    }
}
