using System;
using System.Collections.Generic;
using System.Linq;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            //>>>>>>>>>>>>>>>>[1] >>> Check Magazine
            //string[] mn = Console.ReadLine().Split(' ');
            //int m = Convert.ToInt32(mn[0]);
            //int n = Convert.ToInt32(mn[1]);
            //string[] magazine = Console.ReadLine().Split(' ');
            //string[] note = Console.ReadLine().Split(' ');
            //Solutions.CheckMagazine(magazine, note);

            //>>>>>>>>>>>>>>[2] >>> Two Strings
            //int q = Convert.ToInt32(Console.ReadLine());

            //for (int qItr = 0; qItr < q; qItr++)
            //{
            //    string s1 = Console.ReadLine();

            //    string s2 = Console.ReadLine();

            //    string result = Solutions.TwoStrings(s1, s2);
            //    Console.WriteLine(result);
            //}


            ///>>>>>>>>>>>>>>[3] >>>>SherlockAndAnagrams
            //int q = Convert.ToInt32(Console.ReadLine());

            //for (int qItr = 0; qItr < q; qItr++)
            //{
            //    string s = Console.ReadLine();
            //    int result = Solutions.SherlockAndAnagrams(s);
            //    Console.WriteLine(result);
            //}
            //Console.ReadLine();

            //>>>>>>>>>>>>>>>>>>>>>[4] Count Triplets
            string[] nr = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nr[0]);

            long r = Convert.ToInt64(nr[1]);

            List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

            long ans = Solutions.CountTriplets(arr, r);

        }
    }
}
