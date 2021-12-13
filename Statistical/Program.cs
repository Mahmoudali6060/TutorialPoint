using System;
using System.Collections.Generic;

namespace Statistical
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));
            float sum = 0;
            Dictionary<int, int> repeadtedNumbers = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                sum += q[i];

                repeadtedNumbers.TryGetValue(i, out int value);
                if (value > 0)
                {
                    repeadtedNumbers[i+1] = value++;
                }
                else
                {
                    repeadtedNumbers[i+1] = 1;
                }
            }


            float mean = sum / n;
            float median = 0;

            if (n % 2 == 1)//Odd
            {
                median = q[(n - 1) / 2];
            }
            else//Even
            {
                median = (q[n / 2] + q[(n / 2) + 1]) / 2;
            }
        }
    }
}
