using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new VehicleStateContext(new PowerOffVehicleState());
            context.Handle();
            context.Handle();
            context.Handle();
            context.Handle();

            Console.ReadLine();
        }
    }
}
