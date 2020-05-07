using DesignPatterns.Core;

namespace AbstractFactoryPattern
{
    public class SqlServerConnection : Connection
    {
        public override void Connect()
        {
            LogHelper.Log("Connected to SQL Server");
        }
    }
}
