using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FigureCreator[] creators = new FigureCreator[2];
            creators[0] = new SquareCreator();
            creators[1] = new TriangleCreator();

            foreach (var creator in creators)
            {
                var figure = creator.FactoryMethod();
                Console.WriteLine($"Created figure: {figure.GetName()}");
            }

            Console.ReadLine();
        }
    }
}
