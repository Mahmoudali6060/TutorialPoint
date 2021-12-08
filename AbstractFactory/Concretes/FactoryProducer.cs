using AbstractFactory.Abstractions;
using AbstractFactory.Enums;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Concretes
{
    public class FactoryProducer
    {
        public static AbstractShapeFactory GetShape(bool isRounded)
        {
            if (isRounded == true)
            {
                return new RoundShapeFactory();
            }
            else
            {
                return new ShapeFactory();
            }
        }
    }
}
