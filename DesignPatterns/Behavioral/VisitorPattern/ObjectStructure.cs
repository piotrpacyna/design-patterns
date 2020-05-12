using System.Collections.Generic;

namespace VisitorPattern
{
    public class ObjectStructure
    {
        private readonly List<Element> allElements = new List<Element>();

        public void Add(Element element)
        {
            allElements.Add(element);
        }

        public void Remove(Element element)
        {
            allElements.Remove(element);
        }

        public void Accept(IVisitor visitor)
        {
            allElements.ForEach(x => x.Accept(visitor));
        }
    }
}
