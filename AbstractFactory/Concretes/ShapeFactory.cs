using AbstractFactory.Abstractions;
using AbstractFactory.Enums;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Concretes
{
    public class ShapeFactory : AbstractShapeFactory
    {
        public override IShape GetShape(ShapeTypeEnum shapeType)
        {
            if (shapeType == ShapeTypeEnum.Rectangle)
            {
                return new Rectangle();
            }
            else if (shapeType == ShapeTypeEnum.Square)
            {
                return new Square();
            }
            return null;
        }
    }
}
