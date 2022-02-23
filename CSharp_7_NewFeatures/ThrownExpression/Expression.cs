using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_7_NewFeatures.ThrownExpression
{
    public class Expression
    {
        public static double Divide(int x, int y)
        {
            return y != 0 ? x % y : throw new DivideByZeroException();

            //if (y == 0)
            //    throw new DivideByZeroException();
            //else
            //    return x % y;
        }
    }
}
