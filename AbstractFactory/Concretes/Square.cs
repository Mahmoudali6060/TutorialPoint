using AbstractFactory.Enums;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Concretes
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine(ShapeTypeEnum.Square.ToString());
        }
    }
}
