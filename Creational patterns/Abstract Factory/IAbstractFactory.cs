namespace Abstract_Factory
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA(); 
        IAbstractProductB CreateProductB();
    }
}
