using DesignPatterns.Core;

namespace FacadePattern
{
    public class CarEngine
    {
        public void Create()
        {
            LogHelper.LogMethodCall(LogHelper.MethodType.Main, nameof(Create), nameof(CarEngine));
        }
    }
}
