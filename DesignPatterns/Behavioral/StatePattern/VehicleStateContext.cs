using DesignPatterns.Core;

namespace StatePattern
{
    public class VehicleStateContext
    {
        private IVehicleState state;

        public VehicleStateContext(IVehicleState state)
        {
            this.state = state;
        }

        public void Handle()
        {
            state.Handle(this);
            LogHelper.Log($"Handled to state: {state.GetType().Name}");
        }

        public void SetState(IVehicleState nextState)
        { 
            state = nextState;
        }
    }
}
