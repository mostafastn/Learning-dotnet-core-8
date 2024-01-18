using AbstractFactory.Interface.Product;

namespace AbstractFactory.Interface.Factory
{
    internal interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();

        IAbstractProductB CreateProductB();

        IAbstractProductC CreateProductC();
    }
}
