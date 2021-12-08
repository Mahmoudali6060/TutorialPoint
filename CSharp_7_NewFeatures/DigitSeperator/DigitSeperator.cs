using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_7_NewFeatures.DigitSeperator
{
    static class DigitSeperator
    {
        public static void PrintLongNumber()
        {
            var myData1 = 1__2________3___4____5_____6;
            var myData2 = 1__2___3___4____5_____6.79;
            Console.WriteLine("bigNumber : {0}, bigNumberSplit : {1}", myData1, myData2);
        }
    }
}
