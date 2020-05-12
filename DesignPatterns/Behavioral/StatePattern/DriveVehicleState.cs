namespace StatePattern
{
    public class DriveVehicleState : IVehicleState
    {
        public void Handle(VehicleStateContext context)
        {
            context.SetState(new StopVehicleState());
        }
    }
}
