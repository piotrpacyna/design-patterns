using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new CarFacade();
            facade.Create();

            Console.ReadLine();
        }
    }
}
