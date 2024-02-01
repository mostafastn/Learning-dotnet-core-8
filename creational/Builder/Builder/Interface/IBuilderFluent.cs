using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Interface
{
    internal interface IBuilderFluent

    {
        IBuilderFluent BuildPartA();

        IBuilderFluent BuildPartB();

        IBuilderFluent BuildPartC();

    }
}
