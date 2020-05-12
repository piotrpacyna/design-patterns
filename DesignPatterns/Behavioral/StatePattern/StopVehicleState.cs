namespace StatePattern
{
    public class StopVehicleState : IVehicleState
    {
        public void Handle(VehicleStateContext context)
        {
            context.SetState(new PowerOffVehicleState());
        }
    }
}
