using System;

namespace DesignPatterns.Core
{
    public class LogHelper
    {
        public enum MethodType
        {
            Abstract,
            Main,
            Virtual,
            Overridden
        }

        public static void LogMethodCall(MethodType type, string methodName, string className)
        {
            Console.WriteLine($"{type} {methodName} method called from {className} class");
        }

        public static void LogSeparator()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
