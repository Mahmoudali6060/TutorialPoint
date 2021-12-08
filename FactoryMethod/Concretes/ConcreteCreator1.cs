using FactoryMethod.Abstractions;
using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Concretes
{
    class ConcreteCreator1 : Creator
    {
        public override IProduct CreateProduct()
        {
            return new ConcreteProduct1();
        }
    }
}
