﻿using AbstractFactory.Creator.ConcreteProduct;
using AbstractFactory.Interface.Factory;
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

        public IAbstractProductC CreateProductC()
        {
            return new ConcreteProductC2();
        }
    }
}
