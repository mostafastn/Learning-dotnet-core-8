using AbstractFactory.Creator.ConcreteProduct;
using AbstractFactory.Interface.Factory;
using AbstractFactory.Interface.Product;

namespace AbstractFactory.Creator.ConcreteFactory
{
    internal class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }

        public IAbstractProductC CreateProductC()
        {
            return new ConcreteProductC2();
        }
    }
}
