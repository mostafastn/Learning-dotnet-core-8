using FactoryMethod.Creator;
using FactoryMethod.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Type2
{
    public class ConcreteCreator2 : Creator.Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
