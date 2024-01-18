using AbstractFactory.Interface.Product;

namespace AbstractFactory.Interface
{
    internal interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();

        IAbstractProductB CreateProductB();

        IAbstractProductC CreateProductC();
    }
}
