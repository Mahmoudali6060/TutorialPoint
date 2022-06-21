using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SemaphoreSlimDemo.Helper
{
    public static class SemaphoreSlimHelper
    {
        //only 3 threads can access resource simulteniously
        static SemaphoreSlim semaphore = new SemaphoreSlim(initialCount: 3);

        public static void SemaphoreSlimFunction(string name, int seconds)
        {
            Console.WriteLine($"{name} Waits to access resource");
            semaphore.Wait();
            Console.WriteLine($"{name} was granted access to resource");
            Thread.Sleep(seconds);
            Console.WriteLine($"{name} is completed");
            semaphore.Release();
        }
    }
}
