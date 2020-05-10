using DesignPatterns.Core;

namespace FacadePattern
{
    public class CarFacade
    {
        private readonly CarBody body = new CarBody();
        private readonly CarEngine engine = new CarEngine();
        private readonly CarWheels wheels = new CarWheels();
        private readonly CarDoors doors = new CarDoors();

        public void Create()
        {
            LogHelper.LogMethodCall(LogHelper.MethodType.Main, nameof(Create), nameof(CarFacade));
            body.Create();
            engine.Create();
            wheels.Create();
            doors.Create();
        }
    }
}
