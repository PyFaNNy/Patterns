namespace Abstract_Factory
{
    public interface IAbstractProductB
    {
		string Name { get; }
		string DoWorkB();
		string WorkWithProductA(IAbstractProductA productA);
	}
}
