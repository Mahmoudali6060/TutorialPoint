using AbstractFactory.Enums;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Concretes
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine(ShapeTypeEnum.Rectangle.ToString());
        }
    }
}
