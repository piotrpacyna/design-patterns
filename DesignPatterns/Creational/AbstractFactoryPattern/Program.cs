using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlServerConnectionFactory = new SqlServerConnectionFactory();
            var sqlServerClient = new ServerClient(sqlServerConnectionFactory);
            sqlServerClient.Connect();

            var oracleConnectionFactory = new OracleConnectionFactory();
            var oracleServerClient = new ServerClient(oracleConnectionFactory);
            oracleServerClient.Connect();

            Console.ReadLine();
        }
    }
}
