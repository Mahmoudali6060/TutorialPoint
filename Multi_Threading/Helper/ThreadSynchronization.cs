using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Multi_Threading.Helper
{
    public static class ThreadSynchronization
    {
        static object lockObject = new object();
        static public int count = 0;
        public static void Welcome()
        {
            // Locking the Shared Resource for Thread Synchronization
            lock (lockObject)
            {
                Console.Write("[Welcome To The ");
                Thread.Sleep(1000);
                Console.WriteLine("World of Dotnet!]");
            }
        }

        public static void IncrementCount()
        {
            for (int i = 1; i <= 1000000; i++)
            {
                //Only protecting the shared Count variable
                lock (lockObject)
                {
                    count++;
                }
            }
        }

    }
}
