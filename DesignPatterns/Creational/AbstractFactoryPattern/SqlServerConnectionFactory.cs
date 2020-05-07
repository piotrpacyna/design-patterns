namespace AbstractFactoryPattern
{
    public class SqlServerConnectionFactory : ConnectionFactory
    {
        public override Connection CreateConnection()
        {
            return new SqlServerConnection();
        }
    }
}
