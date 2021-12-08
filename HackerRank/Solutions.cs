using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Arrays
{
    public static class Solutions
    {
        public static int MinimumSwaps(int[] arr)
        {
            int swapCount = 0;
            //#region Bubble Sort
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            int temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //            swapCount++;
            //        }
            //    }
            //}
            //#endregion

            //#region Brude Force Methods
            //int index = 0;
            //while(index < arr.Length)
            //{
            //    if(arr[index] != index + 1)
            //    {
            //        int temp = arr[index];
            //        arr[index] = arr[temp - 1];
            //        arr[temp - 1] = temp;
            //        swapCount++;
            //    }
            //    else
            //    {
            //        index++;
            //    }
            //}
            //#endregion


            return swapCount;
        }

        public static void MinimumBribes(int[] arr)
        {
            int swapCount = 0;
            bool isTooChaotic = false;
            for (int index = arr.Length; index > 0; index--)
            {
                if (arr[index] - (index + 1) > 2)
                {
                    Console.WriteLine("Too chaotic");
                    isTooChaotic = true;
                    break;
                }
                for (int j = Math.Max(0, arr[index] - 2); j < index; j++)
                {
                    if (arr[j] > arr[index])
                        swapCount++;
                }
            }

            if (isTooChaotic == false)
                Console.WriteLine(swapCount);
        }

        //public static long ApplyArrayManipulation(int arraySize, int[][] queries)
        //{
        //    int[] arr = new int[arraySize];
        //    for()
        //}
    }
}
