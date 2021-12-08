using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_7_NewFeatures.PatternMatching
{
    public class Rectangle : Shape
    {
        public double Length { get; }
        public double Height { get; }
        public Rectangle(double length, double height)
        {
            Length = length;
            Height = height;
        }
    }
}
