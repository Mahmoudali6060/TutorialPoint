using AbstractFactory.Enums;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Concretes
{
    public class RoundedSquare : IShape
    {
        public void Draw()
        {
            Console.WriteLine(ShapeTypeEnum.RoundedSquare.ToString());
        }
    }
}
