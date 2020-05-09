using System;
using DesignPatterns.Core;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Uniformity();
            LogHelper.LogSeparator();
            TypeSafety();
            Console.ReadLine();
        }

        private static void Uniformity()
        {
            var root = new Uniformity.FormComposite("UniformityRoot");
            root.Add(new Uniformity.ButtonLeaf("Add"));
            root.Add(new Uniformity.ButtonLeaf("Delete"));

            var formOne = new Uniformity.FormComposite("FormOne");
            formOne.Add(new Uniformity.ButtonLeaf("Remove"));
            formOne.Add(new Uniformity.LabelLeaf("Label"));

            var formTwo = new Uniformity.FormComposite("FormTwo");
            formTwo.Add(new Uniformity.LabelLeaf("First"));
            formTwo.Add(new Uniformity.LabelLeaf("Second"));
            var leafToRemove = new Uniformity.LabelLeaf("LabelToRemove");
            formTwo.Add(leafToRemove);
            formTwo.Remove(leafToRemove);

            formOne.Add(formTwo);
            formOne.Add(new Uniformity.LabelLeaf("Last"));
            root.Add(formOne);
            root.Add(new Uniformity.LabelLeaf("LastRoot"));
            root.Print(1);
        }

        private static void TypeSafety()
        {
            var root = new TypeSafety.FormComposite("TypeSafetyRoot");
            root.Add(new TypeSafety.ButtonLeaf("Add"));
            root.Add(new TypeSafety.ButtonLeaf("Delete"));

            var formOne = new TypeSafety.FormComposite("FormOne");
            formOne.Add(new TypeSafety.ButtonLeaf("Remove"));
            formOne.Add(new TypeSafety.LabelLeaf("Label"));

            var formTwo = new TypeSafety.FormComposite("FormTwo");
            formTwo.Add(new TypeSafety.LabelLeaf("First"));
            formTwo.Add(new TypeSafety.LabelLeaf("Second"));
            var leafToRemove = new TypeSafety.LabelLeaf("LabelToRemove");
            formTwo.Add(leafToRemove);
            formTwo.Remove(leafToRemove);

            formOne.Add(formTwo);
            formOne.Add(new TypeSafety.LabelLeaf("Last"));
            root.Add(formOne);
            root.Add(new TypeSafety.LabelLeaf("LastRoot"));
            root.Print(1);
        }
    }
}
