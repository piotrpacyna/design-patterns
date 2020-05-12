namespace StatePattern
{
    public interface IVehicleState
    {
        void Handle(VehicleStateContext context);
    }
}
