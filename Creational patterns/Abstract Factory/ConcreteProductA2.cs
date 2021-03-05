namespace Abstract_Factory
{
    public class ConcreteProductA2 : IAbstractProductA
    {
		public string Name => "A2";
		public string DoWorkA()
		{
			return "A2 выполнил свою работу.";
		}
	}
}
