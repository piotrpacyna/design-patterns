namespace BuilderPattern
{
    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            Vehicle = new Vehicle("Car");
        }

        public override void BuildFrame()
        {
            Vehicle.CreateFrame("Car frame");
        }

        public override void BuildEngine()
        {
            Vehicle.CreateEngine("Car engine");
        }

        public override void BuildWheels()
        {
            Vehicle.CreateWheels(4);
        }

        public override void BuildDoors()
        {
            Vehicle.CreateDoors(4);
        }
    }
}
