namespace Singleton
{
    class MultiThreadedSingleton
    {
        public string Value { get; set; }
        private MultiThreadedSingleton() { }

        private static MultiThreadedSingleton _instance;

        private static readonly object _lock = new object();

        public static MultiThreadedSingleton GetInstance(string value)
        {
            if (_instance == null)
            {

                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new MultiThreadedSingleton();
                        _instance.Value = value;
                    }
                }
            }
            return _instance;
        }
    }
}
