using System;
using System.Collections.Generic;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context("DLPLPDLLP");
            var expressions = new List<AbstractExpression>
            {
                new DashExpression(),
                new DotExpression(),
                new PlusExpression()
            };

            expressions.ForEach(x => x.Interpret(context));
            context.Log();

            Console.ReadLine();
        }
    }
}
