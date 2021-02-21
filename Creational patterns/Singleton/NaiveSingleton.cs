using System;

namespace Singleton
{
    class NaiveSingleton
    {
        private static NaiveSingleton _instance;
        private NaiveSingleton() { }
        public static NaiveSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new NaiveSingleton();
            }
            return _instance;
        }
        public void work()
        {
            Console.WriteLine("NaiveSingleton work!");
        }
    }
}
