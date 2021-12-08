using System;
using System.IO;

namespace HackerRank.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //>>>>>>>>>>>>>>>>>>>[1] Minimum Swaps
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //int res = Solutions.MinimumSwaps(arr);

            //>>>>>>>>>>>>>>>>>>>[2]  Minimum Bribes
            //int t = Convert.ToInt32(Console.ReadLine());

            //for (int tItr = 0; tItr < t; tItr++)
            //{
            //    int n = Convert.ToInt32(Console.ReadLine());

            //    int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));
            //    Solutions.MinimumBribes(q);
            //}

            ///>>>>>>>>>>>>>>>>>>[3] Array Manipulation
            ///>>> O(m*n)
            string[] nm = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nm[0]);
            int m = Convert.ToInt32(nm[1]);
            int[] newArray = new int[n];
            long maxValue = 0;
            
            for (int i = 0; i < m; i++)
            {
               var queries = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
                for (int j = 0; j < n; j++)
                {
                    if ((j + 1) >= queries[0] && (j + 1) <= queries[1])
                    {
                        newArray[j] = newArray[j] + queries[2];
                        if (newArray[j] > maxValue) maxValue = newArray[j];
                    }
                }
            }

            Console.WriteLine(maxValue);


        }
    }
}
