using MutexDemo.Helpers;
using System;
using System.Threading;

namespace MutexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (Mutex mutex = new Mutex(false, "MutexDemo"))
            //{
            //    //Checking if Other External Thread is Running
            //    if (!mutex.WaitOne(5000, false))
            //    {
            //        Console.WriteLine("An Instance of the Application is Already Running");
            //        Console.ReadKey();
            //        return;
            //    }
            //    Console.WriteLine("Application Is Running.......");
            //    Console.ReadKey();
            //}

            //Create multiple threads to understand Mutex
            for (int i = 1; i <= 5; i++)
            {
                Thread threadObject = new Thread(MutexHelper.MutexDemo)
                {
                    Name = "Thread " + i
                };
                threadObject.Start();
            }
            Console.ReadKey();

        }
    }
}
