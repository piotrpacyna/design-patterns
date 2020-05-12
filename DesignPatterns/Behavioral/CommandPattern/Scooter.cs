using DesignPatterns.Core;

namespace CommandPattern
{
    public class Scooter : IVehicle
    {
        public void PowerOn()
        {
            LogHelper.Log("The engine of a scooter is on");
        }

        public void Drive()
        {
            LogHelper.Log("You drive a scooter");
        }

        public void Stop()
        {
            LogHelper.Log("You stopped a scooter");
        }

        public void PowerOff()
        {
            LogHelper.Log("The engine of a scooter is off");
        }
    }
}
