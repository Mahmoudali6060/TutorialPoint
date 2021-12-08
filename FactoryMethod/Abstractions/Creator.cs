using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Abstractions
{
    abstract class Creator
    {
        public abstract IProduct CreateProduct();

        public string SomeOperation()
        {
            // Call the factory method to create a Product object.
            var product = CreateProduct();
            // Now, use the product.
            var result = "Creator: The same creator's code has just worked with "
                + product.Operation();

            return result;
        }
    }
}
