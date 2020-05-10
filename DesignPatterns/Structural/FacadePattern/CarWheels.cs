using DesignPatterns.Core;

namespace FacadePattern
{
    public class CarWheels
    {
        public void Create()
        {
            LogHelper.LogMethodCall(LogHelper.MethodType.Main, nameof(Create), nameof(CarWheels));
        }
    }
}
