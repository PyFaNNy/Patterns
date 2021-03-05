using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            ConcreteComponent simpleComponent = new ConcreteComponent();

            client.ClientCode(simpleComponent);

            ConcreteDecoratorA decoratorA = new ConcreteDecoratorA(simpleComponent);
            client.ClientCode(decoratorA);

            ConcreteDecoratorB decoratorB = new ConcreteDecoratorB(decoratorA);
            client.ClientCode(decoratorB);
        }
    }
}
