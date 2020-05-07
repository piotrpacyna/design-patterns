using DesignPatterns.Core;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton instance;
        private static readonly object syncLock = new object();

        public static Singleton Instance
        {
            get
            {
                if (instance != null)
                {
                    LogHelper.Log("Instance already created");
                    return instance;
                }

                lock (syncLock)
                {
                    instance ??= new Singleton();
                }

                LogHelper.Log("Instance created");
                return instance;
            }
        }
    }
}
