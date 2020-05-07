namespace BuilderPattern
{
    public class ShopDirector
    {
        public void CreateVehicle(VehicleBuilder builder)
        {
            builder.BuildFrame();
            builder.BuildEngine();
            builder.BuildWheels();
            builder.BuildDoors();
        }
    }
}
