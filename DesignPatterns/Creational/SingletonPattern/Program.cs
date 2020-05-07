using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var instanceOne = Singleton.Instance;
            var instanceTwo = Singleton.Instance;

            if (instanceOne == instanceTwo)
            {
                Console.WriteLine("Instances are the same");
            }

            Console.ReadLine();
        }
    }
}
