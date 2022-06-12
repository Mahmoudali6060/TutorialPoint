using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statistical
{
    public static class Helper
    {
        public static decimal CalculateMean(int[] arr, int length)
        {
            decimal sum = 0;
            foreach (decimal item in arr)
            {
                sum += item;
            }
            return sum / length;
        }
        public static decimal CalculateMedian(int[] arr, int length)
        {
            Array.Sort(arr);
            decimal median;
            //If Odd
            if (length % 2 > 0)
                median = arr[(length - 1) / 2];
            //Id Even
            else
                median = (decimal)(arr[(length / 2) - 1] + arr[length / 2]) / 2;
            return median;
        }
        public static int CalculateMode(int[] arr)
        {
            return arr.GroupBy(v => v)
            .OrderByDescending(g => g.Count())
            .First()
            .Key;
        }

    }
}
