namespace AbstractFactoryPattern
{
    public class ServerClient
    {
        private readonly Connection connection;

        public ServerClient(ConnectionFactory factory)
        {
            connection = factory.CreateConnection();
        }

        public void Connect()
        {
            connection.Connect();
        }
    }
}
