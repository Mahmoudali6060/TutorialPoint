using AbstractFactory.Abstractions;
using AbstractFactory.Enums;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Concretes
{
    public class RoundShapeFactory : AbstractShapeFactory
    {
        public override IShape GetShape(ShapeTypeEnum shapeType)
        {
            if (shapeType == ShapeTypeEnum.RoundedRectangle)
            {
                return new RoundedRectangle();
            }
            else if (shapeType == ShapeTypeEnum.RoundedSquare)
            {
                return new RoundedSquare();
            }
            return null;
        }
    }
}
