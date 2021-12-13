using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_7_NewFeatures.RefLocalRefReturn
{
    public static class RefReturn
    {
        public static ref int GetFirstOddNumber(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    return ref numbers[i]; //returning as reference  
                }
            }
            throw new Exception("odd number not found");
        }
    }
}
