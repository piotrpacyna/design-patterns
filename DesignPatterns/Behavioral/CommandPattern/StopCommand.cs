namespace CommandPattern
{
    public class StopCommand : ICommand
    {
        private readonly IVehicle vehicle;

        public StopCommand(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public void Execute()
        {
            vehicle.Stop();
        }
    }
}
