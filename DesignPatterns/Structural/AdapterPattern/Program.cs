using System;
using AdapterPattern.Class;
using AdapterPattern.Object;
using DesignPatterns.Core;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget classAdapter = new ClassAdapter();
            classAdapter.Convert();

            LogHelper.LogSeparator();

            ITarget objectAdapter = new ObjectAdapter();
            objectAdapter.Convert();

            Console.ReadLine();
        }
    }
}
