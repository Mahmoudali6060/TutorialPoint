using AbstractFactory.Enums;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Concretes
{
    public class RoundedRectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine(ShapeTypeEnum.RoundedRectangle.ToString());
        }
    }
}
