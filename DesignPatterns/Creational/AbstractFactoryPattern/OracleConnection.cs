using DesignPatterns.Core;

namespace AbstractFactoryPattern
{
    public class OracleConnection : Connection
    {
        public override void Connect()
        {
            LogHelper.Log("Connected to Oracle");
        }
    }
}
