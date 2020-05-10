using System;
using DesignPatterns.Core;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var youngDriver = new ProxyScooter(new Driver(10));
            youngDriver.Drive();

            LogHelper.LogSeparator();

            var oldDriver = new ProxyScooter(new Driver(60));
            oldDriver.Drive();

            Console.ReadLine();
        }
    }
}
