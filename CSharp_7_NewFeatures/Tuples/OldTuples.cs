using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_7_NewFeatures.Tuples
{
    public class OldTuples
    {
        /*>>>>>>>>>>>>>>>>>>Major Problems with Old Tuples
        There are 3 major problems in the below code with Tuple:
        >>[1] Tuples are class  (Refrence Types) >> Stored in heap >>>(Performance Issue)
        >>[2] Elements did not have any names 
        >>[3] Maximum of properties are 8 elelments
        */
        //Declaring the return type as Tuple<int, double>
        public static Tuple<int, double> Calulate(IEnumerable<double> values)
        {
            int count = 0;
            double sum = 0.0;
            foreach (var value in values)
            {
                count++;
                sum += value;
            }
            //Creating an object of Tuple class by calling the static Create method
            Tuple<int, double> t = Tuple.Create(count, sum);
            //Returning the tuple instance
            return t;
        }
    }
}
