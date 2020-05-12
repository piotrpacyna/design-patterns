namespace StatePattern
{
    public class PowerOnVehicleState : IVehicleState
    {
        public void Handle(VehicleStateContext context)
        {
            context.SetState(new DriveVehicleState());
        }
    }
}
