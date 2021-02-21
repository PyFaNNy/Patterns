using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            NaiveSingleton s1 = NaiveSingleton.GetInstance();
            NaiveSingleton s2 = NaiveSingleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("NaiveSingleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("NaiveSingleton failed, variables contain different instances.");
            }
            s1.work();
        }
    }
}
