namespace CommandPattern
{
    public class Driver
    {
        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
        }
    }
}
