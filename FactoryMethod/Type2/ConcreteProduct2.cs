using FactoryMethod.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Type2
{
    public class ConcreteProduct2 : IProduct
    {
        public string Opration()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}
