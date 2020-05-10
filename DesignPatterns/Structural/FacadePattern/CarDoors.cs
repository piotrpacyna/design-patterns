using DesignPatterns.Core;

namespace FacadePattern
{
    public class CarDoors
    {
        public void Create()
        {
            LogHelper.LogMethodCall(LogHelper.MethodType.Main, nameof(Create), nameof(CarDoors));
        }
    }
}
