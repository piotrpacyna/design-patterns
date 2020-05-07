namespace AbstractFactoryPattern
{
    public abstract class ConnectionFactory
    {
        public abstract Connection CreateConnection();
    }
}
