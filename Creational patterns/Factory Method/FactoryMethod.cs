namespace Factory_Method
{

    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();
    }

    public class ConcreteCreator : Creator
    {
        public override IProduct FactoryMethod()
        {
            return  new ConcreteProduct();
        }
    }

    public interface IProduct
    {
        string Name { get; set; }
        void DoWork();
    }

    public class ConcreteProduct : IProduct
    {
        public string Name { get; set; }

        public void DoWork()
        {
            // Magic!
        }
    }
}
