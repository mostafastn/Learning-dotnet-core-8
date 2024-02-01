using Builder.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Creator
{
    internal class Director
    {
        private IBuilder _builder { get; set; }
        private IBuilderFluent _builderFluent { get; set; }

        public Director()
        {

        }

        public Director(IBuilder builder,
            IBuilderFluent builderFluent)
        {
            _builder = builder;
            _builderFluent = builderFluent;
        }


        // The Director can construct several product variations using the same
        // building steps.
        public void BuildMinimalViableProduct()
        {
            this._builder.BuildPartA();
        }

        public void BuildFullFeaturedProduct()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartB();
            this._builder.BuildPartC();
        }

        public void BuildFeaturedProduct()
        {
            this._builderFluent.BuildPartA().BuildPartB().BuildPartC();
        }
    }
}
