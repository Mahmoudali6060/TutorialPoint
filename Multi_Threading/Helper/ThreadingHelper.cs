using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Multi_Threading.Helper
{
    public class ThreadingHelper
    {
        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Introduction to Threading
        public static void Method1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method1 :" + i);
            }
        }
        public static void Method2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method2 :" + i);
                if (i == 3)
                {
                    Console.WriteLine("Performing the Database Operation Started");
                    //Sleep for 10 seconds
                    Thread.Sleep(10000);
                    Console.WriteLine("Performing the Database Operation Completed");
                }
            }
        }
        public static void Method3(object num)
        {
            int convertedNum =(int) num;
            for (int i = 1; i <= convertedNum; i++)
            {
                Console.WriteLine("Method3 :" + i);
            }
        }
    }
}
