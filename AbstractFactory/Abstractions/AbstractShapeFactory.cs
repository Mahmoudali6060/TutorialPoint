using AbstractFactory.Enums;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Abstractions
{
    public abstract class AbstractShapeFactory
    {
        public abstract IShape GetShape(ShapeTypeEnum shapeType);
    }
}
