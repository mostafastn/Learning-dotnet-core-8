using AbstractFactory.Interface.Product;

namespace AbstractFactory.Creator.ConcreteProduct
{
    internal class ConcreteProductC1 : IAbstractProductC
    {
        public string UsefulFunctionC()
        {
            return "The result of the product C1.";
        }
    }

}
