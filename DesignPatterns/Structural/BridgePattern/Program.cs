using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var circleOne = new Circle(new DashDrawApi());
            circleOne.Draw();

            var circleTwo = new Circle(new DotDrawApi());
            circleTwo.Draw();

            Console.ReadLine();
        }
    }
}
