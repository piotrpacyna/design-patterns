namespace BuilderPattern
{
    public class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder()
        {
            Vehicle = new Vehicle("Scooter");
        }

        public override void BuildFrame()
        {
            Vehicle.CreateFrame("Scooter frame");
        }

        public override void BuildEngine()
        {
            Vehicle.CreateEngine("Scooter engine");
        }

        public override void BuildWheels()
        {
            Vehicle.CreateWheels(2);
        }

        public override void BuildDoors()
        {
            Vehicle.CreateDoors(0);
        }
    }
}
