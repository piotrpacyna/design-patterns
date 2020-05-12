namespace InterpreterPattern
{
    public class DashExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            context.Output = context.Output.Replace("L", "-");
        }
    }
}
