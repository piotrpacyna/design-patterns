using System;
using DesignPatterns.Core;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new Driver();
            var car = new Car();
            var scooter = new Scooter();
            DriveVehicle(car, driver);
            LogHelper.LogSeparator();
            DriveVehicle(scooter, driver);

            Console.ReadLine();
        }

        private static void DriveVehicle(IVehicle vehicle, Driver driver)
        {
            ICommand powerOnCommand = new PowerOnCommand(vehicle);
            ICommand powerOffCommand = new PowerOffCommand(vehicle);
            ICommand driveCommand = new DriveCommand(vehicle);
            ICommand stopCommand = new StopCommand(vehicle);

            driver.ExecuteCommand(powerOnCommand);
            driver.ExecuteCommand(driveCommand);
            driver.ExecuteCommand(stopCommand);
            driver.ExecuteCommand(powerOffCommand);
        }
    }
}
