using FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Type1
{
    public class ConcreteProduct1 : IProduct
    {
        public string Opration()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}
