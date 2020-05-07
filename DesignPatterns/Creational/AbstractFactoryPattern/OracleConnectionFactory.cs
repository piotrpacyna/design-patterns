namespace AbstractFactoryPattern
{
    public class OracleConnectionFactory : ConnectionFactory
    {
        public override Connection CreateConnection()
        {
            return new OracleConnection();
        }
    }
}
