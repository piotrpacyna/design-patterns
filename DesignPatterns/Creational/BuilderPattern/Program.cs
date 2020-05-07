using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var shopDirectory = new ShopDirector();

            var carBuilder = new CarBuilder();
            shopDirectory.CreateVehicle(carBuilder);
            var car = carBuilder.Vehicle;
            car.Print();

            var scooterBuilder = new ScooterBuilder();
            shopDirectory.CreateVehicle(scooterBuilder);
            var scooter = scooterBuilder.Vehicle;
            scooter.Print();

            Console.ReadLine();
        }
    }
}
