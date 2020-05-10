using DesignPatterns.Core;

namespace FacadePattern
{
    public class CarBody
    {
        public void Create()
        {
            LogHelper.LogMethodCall(LogHelper.MethodType.Main, nameof(Create), nameof(CarBody));
        }
    }
}
