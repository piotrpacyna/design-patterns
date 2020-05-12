namespace StatePattern
{
    public class PowerOffVehicleState : IVehicleState
    {
        public void Handle(VehicleStateContext context)
        {
            context.SetState(new PowerOnVehicleState());
        }
    }
}
