using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashTables
{
    class Solutions
    {
        public static void CheckMagazine(string[] magazine, string[] note)
        {
            Hashtable htMagazine = new Hashtable();
            Hashtable htNote = new Hashtable();
            string isCopied = "Yes";

            foreach (string word in magazine)
            {
                if (htMagazine[word] == null)
                {
                    htMagazine[word] = 1;
                }
                else
                {
                    htMagazine[word] = (int)htMagazine[word] + 1;
                }
            }

            foreach (string word in note)
            {
                if (htNote[word] == null)
                {
                    htNote[word] = 1;
                }
                else
                {
                    htNote[word] = (int)htNote[word] + 1;
                }
            }

            foreach (string wordNote in note)
            {
                if (htMagazine[wordNote] == null || ((int)htNote[wordNote] > (int)htMagazine[wordNote]))
                {
                    isCopied = "No";
                    break;
                }
            }

            Console.WriteLine(isCopied);
        }

        public static string TwoStrings(string s1, string s2)
        {
            Hashtable ht = new Hashtable();
            for (int i = 0; i < s1.Length; i++)
            {
                ht[s1[i]] = i;
            }

            for (int i = 0; i < s2.Length; i++)
            {
                if (ht[s2[i]] != null)
                {
                    return "YES";
                }

            }
            return "NO";
        }

        public static int SherlockAndAnagrams(string s)
        {
            Hashtable ht = new Hashtable();
            int count = 0;
            for (int i = 1; i <= s.Length - 1; i++)
            {
                for (int j = 0; j <= s.Length - i; j++)
                {
                    var norm = new string(s.Substring(j, i).OrderBy(c => c).ToArray());
                    if (ht[norm] == null)
                    {
                        ht[norm] = 1;
                    }
                    else
                    {
                        count += (int)ht[norm];
                        ht[norm] = (int)ht[norm] + 1;
                    }

                }
            }
            return count;
        }

        public static long CountTriplets(List<long> arr, long r)
        {
            Dictionary<long, long[]> numbers = new Dictionary<long, long[]>();
            long count = 0;
            foreach (long number in arr)
            {
                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, new long[] { 0, 0 });
                }

                if (number % r == 0 && numbers.ContainsKey(number / r))
                {
                    var preNumber = numbers[number / r];
                    count += preNumber[1];
                    numbers[number][1] += preNumber[0];
                }
                numbers[number][0]++;
            }
            return count;
        }
    }
}
