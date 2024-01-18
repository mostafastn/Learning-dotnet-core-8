using AbstractFactory.Creator.ConcreteProduct;
using AbstractFactory.Interface;
using AbstractFactory.Interface.Product;

namespace AbstractFactory.Creator.ConcreteFactory
{
    internal class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }
}
