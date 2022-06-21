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

        public static void weightedMean(List<int> X, List<int> W)
        {
            double xSum = 0.0D;
            double wSum = 0.0D;

            for (int i = 1; i <= X.Count(); i++)
            {
                xSum += W[i - 1] * X[i - 1];
                wSum += W[i - 1];
            }

            double result = Math.Round(xSum / wSum, 1);
            string gg = result.ToString();
            if (!gg.Contains("."))
            {
                gg += ".0";
            }
            Console.WriteLine(gg);
        }
    }
}
