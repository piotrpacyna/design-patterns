using DesignPatterns.Core;

namespace CommandPattern
{
    public class Car : IVehicle
    {
        public void PowerOn()
        {
            LogHelper.Log("The engine of a car is on");
        }

        public void Drive()
        {
            LogHelper.Log("You drive a car");
        }

        public void Stop()
        {
            LogHelper.Log("You stopped a car");
        }

        public void PowerOff()
        {
            LogHelper.Log("The engine of a car is off");
        }
    }
}
