using DesignPatterns.Core;

namespace ProxyPattern
{
    public class ProxyScooter : IVehicle
    {
        private readonly Driver driver;
        private readonly IVehicle vehicle;

        public ProxyScooter(Driver driver)
        {
            this.driver = driver;
            vehicle = new Scooter();
        }

        public void Drive()
        {
            LogHelper.Log($"Driver with age: {driver.Age}");

            if (driver.Age < 18)
            {
                LogHelper.Log("Sorry, you are too young to drive.");
            }
            else
            {
                vehicle.Drive();
            }
        }
    }
}
