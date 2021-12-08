using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_7_NewFeatures.PatternMatching
{
    public class Circle : Shape
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
