namespace CommandPattern
{
    public class PowerOnCommand : ICommand
    {
        private readonly IVehicle vehicle;

        public PowerOnCommand(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public void Execute()
        {
            vehicle.PowerOn();
        }
    }
}
