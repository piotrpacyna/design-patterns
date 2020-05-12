using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    public class DotExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            context.Output = context.Output.Replace("D", ".");
        }
    }
}
