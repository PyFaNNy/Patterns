using System;
using System.Threading;

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


            Thread process2 = new Thread(() =>
            {
                TestSingleton("BAR");
            });
            Thread process1 = new Thread(() =>
            {
                TestSingleton("FOO");
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();
        }
        public static void TestSingleton(string value)
        {
            MultiThreadedSingleton singleton = MultiThreadedSingleton.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }
    }
}
