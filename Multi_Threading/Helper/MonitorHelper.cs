using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Multi_Threading.Helper
{
    public class MonitorHelper
    {

        static readonly object lockObject = new object();

        public static void PrintNumbers()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " Trying to enter into the critical section");
            Monitor.Enter(lockObject);
            try
            {
                Console.WriteLine(Thread.CurrentThread.Name + " Entered into the critical section");
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(100);
                    Console.Write(i + ",");
                }
                Console.WriteLine();
            }
            finally
            {
                Monitor.Exit(lockObject);
                Console.WriteLine(Thread.CurrentThread.Name + " Exit from critical section");
            }
        }

    }
}
