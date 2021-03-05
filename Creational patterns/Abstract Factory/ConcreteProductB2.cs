namespace Abstract_Factory
{
    class ConcreteProductB2 : IAbstractProductB
	{
		public string Name => "B2";
		public string DoWorkB()
		{
			return "B2 выполнил свою работу.";
		}
		public string WorkWithProductA(IAbstractProductA productA)
		{
			return $"B2 выполнил работу совместно с ({productA.Name})";
		}
	}
}
