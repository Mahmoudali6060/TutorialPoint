using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_7_NewFeatures.PatternMatching
{
    public static class PattenMatchingHelper
    {
        public static void DisplayArea(Shape shape)
        {
            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Old Mechanism
            //if (shape is Circle)
            //{
            //    Circle c = (Circle)shape;
            //    Console.WriteLine("Area of Circle is : " + c.Radius * c.Radius * Shape.PI);
            //}
            //else if (shape is Rectangle)
            //{
            //    Rectangle r = (Rectangle)shape;
            //    Console.WriteLine("Area of Rectangle is : " + r.Length * r.Height);
            //}
            //else if (shape is Triangle)
            //{
            //    Triangle t = (Triangle)shape;
            //    Console.WriteLine("Area of Triangle is : " + 0.5 * t.Base * t.Height);
            //}
            //else
            //{
            //    throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
            //}
            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>End Old Mechanism


            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>New Mechanism using  "IS"
            //if (shape is Circle c)//If shape is type of circle,then assign shape object to variable c
            //{
            //    Console.WriteLine("Area of Circle is : " + c.Radius * c.Radius * Shape.PI);
            //}
            //else if (shape is Rectangle r)
            //{
            //    Console.WriteLine("Area of Rectangle is : " + r.Length * r.Height);
            //}
            //else if (shape is Triangle t)
            //{
            //    Console.WriteLine("Area of Triangle is : " + 0.5 * t.Base * t.Height);
            //}
            //else
            //{
            //    throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
            //}

            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>End New Mechanism using  "IS"


            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>New Mechanism using  "Switch"
            //switch (shape)
            //{
            //    case Circle c:
            //        Console.WriteLine("Area of Circle is : " + c.Radius * c.Radius * Shape.PI);
            //        break;
            //    case Rectangle r:
            //        Console.WriteLine("Area of Rectangle is : " + r.Length * r.Height);
            //        break;
            //    case Triangle t:
            //        Console.WriteLine("Area of Triangle is : " + 0.5 * t.Base * t.Height);
            //        break;
            //    default:
            //        throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
            //    case null:
            //        throw new ArgumentNullException(nameof(shape));
            //}
            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>End New Mechanism using  "Switch"


            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Add Condition in case 
            switch (shape)
            {
                case Rectangle r when r.Length == r.Height:
                    Console.WriteLine("Area of Sqaure is : " + r.Length * r.Height);
                    break;
                case Rectangle r:
                    Console.WriteLine("Area of Rectangle is : " + r.Length * r.Height);
                    break;
                case Circle c:
                    Console.WriteLine("Area of Circle is : " + c.Radius * c.Radius * Shape.PI);
                    break;
                case Triangle t:
                    Console.WriteLine("Area of Triangle is : " + 0.5 * t.Base * t.Height);
                    break;
                default:
                    throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
            }
            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>End Add Condition in case 
        }
    }
}
