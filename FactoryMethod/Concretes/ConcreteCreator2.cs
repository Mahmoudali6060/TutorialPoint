﻿using FactoryMethod.Abstractions;
using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Concretes
{
    class ConcreteCreator2 : Creator
    {
        public override IProduct CreateProduct()
        {
            return new ConcreteProduct2();
        }
    }
}