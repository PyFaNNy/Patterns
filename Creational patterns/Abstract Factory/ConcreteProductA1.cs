namespace Abstract_Factory
{
    public class ConcreteProductA1 : IAbstractProductA
    {
        public string Name => "A1";
        public string DoWorkA()
        {
            return "A1 выполнил свою работу.";
        }
    }
}
