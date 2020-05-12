namespace InterpreterPattern
{
    public class PlusExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            context.Output = context.Output.Replace("P", "+");
        }
    }
}
