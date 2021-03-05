namespace Abstract_Factory
{
    public class ConcreteProductB1 : IAbstractProductB
    {
		public string Name => "B1";
		public string DoWorkB()
		{
			return "B1 выполнил свою работу.";
		}
		public string WorkWithProductA(IAbstractProductA productA)
		{
			return $"B1 выполнил работу совместно с ({productA.Name})";
		}
	}
}
