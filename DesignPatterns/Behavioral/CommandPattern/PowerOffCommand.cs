namespace CommandPattern
{
    public class PowerOffCommand : ICommand
    {
        private readonly IVehicle vehicle;

        public PowerOffCommand(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public void Execute()
        {
            vehicle.PowerOff();
        }
    }
}
