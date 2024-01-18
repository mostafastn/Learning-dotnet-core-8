using AbstractFactory.Interface.Product;

namespace AbstractFactory.Creator.ConcreteProduct
{
    internal class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A1.";
        }
    }

}
