using System;

namespace Strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Сlient client = new Сlient();
            client.SetStrategy(new ConcreteStrategyA());
            client.DoWork();
            client.SetStrategy(new ConcreteStrategyB());
            client.DoWork();
        }
    }
}
