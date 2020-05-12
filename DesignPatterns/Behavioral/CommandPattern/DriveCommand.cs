namespace CommandPattern
{
    public class DriveCommand : ICommand
    {
        private readonly IVehicle vehicle;

        public DriveCommand(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public void Execute()
        {
            vehicle.Drive();
        }
    }
}
