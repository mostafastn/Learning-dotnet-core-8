using AbstractFactory.Interface.Product;

namespace AbstractFactory.Creator.ConcreteProduct
{
    internal class ConcreteProductC2 : IAbstractProductC
    {
        public string UsefulFunctionC()
        {
            return "The result of the product C2.";
        }
    }

}
