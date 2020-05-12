using DesignPatterns.Core;

namespace InterpreterPattern
{
    public class Context
    {
        public string Input { get; }
        public string Output { get; set; }

        public Context(string input)
        {
            Input = input;
            Output = input;
        }

        public void Log()
        {
            LogHelper.Log(Input);
            LogHelper.Log(Output);
        }
    }
}
