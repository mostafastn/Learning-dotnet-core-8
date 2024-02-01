using Builder.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Creator
{
    internal class ConcreteBuilderFluent : IBuilderFluent
    {
        private Product _product = new Product();

        // A fresh builder instance should contain a blank product object, which
        // is used in further assembly.
        public ConcreteBuilderFluent()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Product();
        }

        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }

        public IBuilderFluent BuildPartA()
        {
            this._product.Add("PartA1");
            return this;
        }

        public IBuilderFluent BuildPartB()
        {
            this._product.Add("PartB1");
            return this;
        }

        public IBuilderFluent BuildPartC()
        {
            this._product.Add("PartC1");
            return this;
        }
    }
}
