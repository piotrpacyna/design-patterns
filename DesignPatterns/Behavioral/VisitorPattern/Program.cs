using System;
using DesignPatterns.Core;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var structure = new ObjectStructure();
            structure.Add(new FirstElement());
            structure.Add(new SecondElement());

            var firstVisitor = new FirstVisitor();
            var secondVisitor = new SecondVisitor();

            structure.Accept(firstVisitor);
            LogHelper.LogSeparator();
            structure.Accept(secondVisitor);

            Console.ReadLine();
        }
    }
}
