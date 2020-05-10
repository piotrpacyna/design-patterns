using DesignPatterns.Core;

namespace ProxyPattern
{
    public class Scooter : IVehicle
    {
        public void Drive()
        {
            LogHelper.Log("You drive a scooter");
        }
    }
}
