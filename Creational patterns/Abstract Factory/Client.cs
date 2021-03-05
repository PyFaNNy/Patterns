using System;

namespace Abstract_Factory
{
    public class Client
    {
		public void DoWork()
		{
			CreateProducts(new ConcreteFactory1());
			CreateProducts(new ConcreteFactory2());
		}
		private void CreateProducts(IAbstractFactory factory)
		{
			var productA = factory.CreateProductA();
			var productB = factory.CreateProductB();

			Console.WriteLine(productB.DoWorkB());
			Console.WriteLine(productB.WorkWithProductA(productA));
		}
	}
}
