using System;
using System.Diagnostics;
using System.Threading;

namespace ThreadPoolApplication
{
    class Program
    {
        /// <summary>
        /// So it proves that the thread pool gives better performance as compared to the thread class object.
        /// If there are need to create one or two threads then you need to use the Thread class object 
        /// while if there is a need to create more than 5 threads
        /// then you need to go for the thread pool class in a multithreaded environment.
        /// </summary>
        /// <param name="args"></param>


        //Limit numbers will be printed on the Console
        const int numberLimit = 10;
        static readonly object _lockObject = new object();
        static void Main(string[] args)
        {
            #region Thread pool

            //    //for (int i = 0; i < 10; i++)
            //    //{
            //    //    MethodWithThread();
            //    //    MethodWithThreadPool();
            //    //}
            //    //Stopwatch stopwatch = new Stopwatch();
            //    //Console.WriteLine("Execution using Thread");
            //    //stopwatch.Start();
            //    //MethodWithThread();
            //    //stopwatch.Stop();
            //    //Console.WriteLine("Time consumed by MethodWithThread is : " +
            //    //                     stopwatch.ElapsedTicks.ToString());

            //    //stopwatch.Reset();
            //    //Console.WriteLine("Execution using Thread Pool");
            //    //stopwatch.Start();
            //    //MethodWithThreadPool();
            //    //stopwatch.Stop();
            //    //Console.WriteLine("Time consumed by MethodWithThreadPool is : " +
            //    //                     stopwatch.ElapsedTicks.ToString());


            #endregion

            #region Thread [Background and Foreground]
            //    // A thread created here to run Method1 Parallely
            //    //Thread thread1 = new Thread(Method1);
            //    //thread1.IsBackground = true;
            //    //Console.WriteLine($"Thread1 is a Background thread:  {thread1.IsBackground}");
            //    //thread1.Start();
            //    ////The control will come here and will exit 
            //    ////the main thread or main application
            //    //Console.WriteLine("Main Thread Exited");
            //    #endregion

            //    #region Thread State
            //    // Creating and initializing threads Unstarted state
            //    Thread thread1 = new Thread(SomeMethod);
            //    Console.WriteLine($"ThreadState: {thread1.ThreadState}");
            //    // Running state
            //    thread1.Start();
            //    Console.WriteLine($"ThreadState: {thread1.ThreadState}");
            //    // thread1 is in suspended state
            //    thread1.Suspend();
            //    Console.WriteLine($"ThreadState: {thread1.ThreadState}");
            //    // thread1 is resume to running state
            //    thread1.Resume();
            //    Console.WriteLine($"ThreadState: {thread1.ThreadState}");
            //    // thread1 is in Abort state
            //    thread1.Abort();
            //    Console.WriteLine($"ThreadState: {thread1.ThreadState}");
            //    Console.ReadKey();
            #endregion

            #region InterthreadCommunications
            //Thread EvenThread = new Thread(PrintEvenNumbers);
            //Thread OddThread = new Thread(PrintOddNumbers);
            ////First Start the Even thread.
            //EvenThread.Start();
            ////Pause for 10 ms, to make sure Even thread has started 
            ////or else Odd thread may start first resulting different sequence.
            //Thread.Sleep(100);
            ////Next, Start the Odd thread.
            //OddThread.Start();
            ////Wait for all the childs threads to complete
            //OddThread.Join();
            //EvenThread.Join();
            #endregion

            #region Debug Multi-Threaded App
            Thread thread1 = new Thread(SomeMethod2)
            {
                Name = "Thread One"
            };
            Thread thread2 = new Thread(SomeMethod2)
            {
                Name = "Thread Two"
            };

            thread1.Start();
            thread2.Start();
            Console.ReadKey();
            #endregion

            Console.Read();
        }

        #region Thread pool
        //public static void MethodWithThread()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Thread thread = new Thread(Test);
        //    }
        //}
        //public static void MethodWithThreadPool()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        ThreadPool.QueueUserWorkItem(new WaitCallback(Test));
        //    }
        //}
        //public static void Test(object obj)
        //{
        //}
        #endregion

        #region Thread Foreground and Background
        // Static method
        //static void Method1()
        //{
        //    Console.WriteLine("Method1 Started");
        //    for (int i = 0; i <= 5; i++)
        //    {
        //        Console.WriteLine("Method1 is in Progress!!");
        //        Thread.Sleep(1000);
        //    }
        //    Console.WriteLine("Method1 Exited");
        //    Console.WriteLine("Press any key to Exit.");
        //    Console.ReadKey();
        //}

        #endregion

        #region Thread State
        public static void SomeMethod()
        {
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("SomeMethod.....");
            }
        }
        #endregion

        #region  InterthreadCommunications

        //Printing of Even Numbers Function
        static void PrintEvenNumbers()
        {
            try
            {
                //Implement lock as the Console is shared between two threads
                Monitor.Enter(_lockObject);
                for (int i = 0; i <= numberLimit; i = i + 2)
                {
                    //Printing Even Number on Console)
                    Console.Write($"{i} ");
                    //Notify Odd thread that I'm done, you do your job
                    Monitor.Pulse(_lockObject);
                    //I will wait here till Odd thread notify me 
                    // Monitor.Wait(monitor);
                    //Without this logic application will wait forever
                    bool isLast = false;
                    if (i == numberLimit)
                    {
                        isLast = true;
                    }
                    if (!isLast)
                    {
                        //I will wait here till Odd thread notify me
                        Monitor.Wait(_lockObject);
                    }
                }
            }
            finally
            {
                //Release the lock
                Monitor.Exit(_lockObject);
            }
        }
        //Printing of Odd Numbers Function
        static void PrintOddNumbers()
        {
            try
            {
                //Hold lock as the Console is shared between two threads
                Monitor.Enter(_lockObject);
                for (int i = 1; i <= numberLimit; i = i + 2)
                {
                    //Printing the odd numbers on the console
                    Console.Write($"{i} ");
                    //Notify Even thread that I'm done, you do your job
                    Monitor.Pulse(_lockObject);
                    //I will wait here till even thread notify me
                    // Monitor.Wait(monitor);
                    // without this logic application will wait forever
                    bool isLast = false;
                    if (i == numberLimit - 1)
                    {
                        isLast = true;
                    }
                    if (!isLast)
                    {
                        //I will wait here till Even thread notify me
                        Monitor.Wait(_lockObject);
                    }
                }
            }
            finally
            {
                //Release lock
                Monitor.Exit(_lockObject);
            }
        }


        #endregion

        #region Debug Multi-Threaded App
        public static void SomeMethod2()
        {
            for (int i = 0; i < 10; i++)
            {
                i++;
                Thread.Sleep(5000);
            }
        }
        #endregion

    }
}
