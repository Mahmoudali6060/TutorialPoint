using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_7_NewFeatures.PatternMatching
{
    public class Triangle : Shape
    {
        public double Base { get; }
        public double Height { get; }
        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }
    }
}
