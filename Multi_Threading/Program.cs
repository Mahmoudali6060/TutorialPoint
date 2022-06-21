using Multi_Threading.Helper;
using System;
using System.Threading;

namespace Multi_Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Introduction to Threading
            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Introduction to Threading
            ////Multi-Threading in C#
            //Console.WriteLine("Main Thread Started");

            ////Creating Threads
            //Thread t1 = new Thread(ThreadingHelper.Method1)
            //{
            //    Name = "Thread1"
            //};
            //Thread t2 = new Thread(ThreadingHelper.Method2)
            //{
            //    Name = "Thread2"
            //};

            //Thread t3 = new Thread(ThreadingHelper.Method3)
            //{
            //    Name = "Thread3"
            //};

            ////ParameterizedThreadStart PTSD = new ParameterizedThreadStart(ThreadingHelper.Method3);
            ////Thread t3 = new Thread(PTSD);

            ////Executing the methods
            //t1.Start();
            //t2.Start();
            //t3.Start(100);

            //Console.WriteLine("Main Thread Ended");
            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>End Introduction to Threading

            #endregion

            #region Retreive Data 

            ///////////>>>>>>>>>>>>>>>>>>>>Retreive Data 

            ////Create the ResultCallbackDelegate instance and to its constructor 
            ////pass the callback method name
            //ResultCallbackDelegate resultCallbackDelegate = new ResultCallbackDelegate(ResultCallBackMethod);
            //int Number = 10;
            ////Creating the instance of NumberHelper class by passing the Number
            ////the callback delegate instance
            //DataRetrieving obj = new DataRetrieving(Number, resultCallbackDelegate);
            ////Creating the Thread using ThreadStart delegate
            //Thread T1 = new Thread(new ThreadStart(obj.CalculateSum));

            //T1.Start();

            #endregion

            #region Join and IsLive
            ///////////////>>>>>>>>>>>>>>>>Using Join and IsLive
            Console.WriteLine("Main Thread Started");
            //Main Thread creating three child threads
            //Thread thread1 = new Thread(JoinMethodHelper.Method1);
            //Thread thread2 = new Thread(JoinMethodHelper.Method2);
            //Thread thread3 = new Thread(JoinMethodHelper.Method3);
            //thread1.Start();
            //thread2.Start();
            //thread3.Start();

            //thread1.Join();
            //thread2.Join();
            //thread3.Join();

            //if (thread3.Join(3000))
            //{
            //    Console.WriteLine("Thread 3 Execution Completed in 3 second");
            //}
            //else
            //{
            //    Console.WriteLine("Thread 3 Execution Not Completed in 3 second");
            //}


            //if (thread1.IsAlive)
            //{
            //    Console.WriteLine("Thread1 Method1 is still doing its work");
            //}
            //else
            //{
            //    Console.WriteLine("Thread1 Method1 Completed its work");
            //}

            //Console.WriteLine("Main Thread Ended");
            //Console.Read();

            #endregion

            #region Thread Synchronization
            //Thread thread1 = new Thread(ThreadSynchronization.Welcome)
            //{
            //    Name = "Thread 1"
            //};
            //Thread thread2 = new Thread(ThreadSynchronization.Welcome)
            //{
            //    Name = "Thread 2"
            //};
            //Thread thread3 = new Thread(ThreadSynchronization.Welcome)
            //{
            //    Name = "Thread 2"
            //};
            //thread1.Start();
            //thread2.Start();
            //thread3.Start();

            #endregion

            #region Using Lock
            //Thread t1 = new Thread(ThreadSynchronization.IncrementCount);
            //Thread t2 = new Thread(ThreadSynchronization.IncrementCount);
            //Thread t3 = new Thread(ThreadSynchronization.IncrementCount);
            //t1.Start();
            //t2.Start();
            //t3.Start();
            ////Wait for all three threads to complete their execution
            //t1.Join();
            //t2.Join();
            //t3.Join();
            //Console.WriteLine(ThreadSynchronization.count);
            //Console.Read();
            #endregion

            #region Monitor

            Thread[] Threads = new Thread[3];
            for (int i = 0; i < 3; i++)
            {
                Threads[i] = new Thread(MonitorHelper.PrintNumbers);
                Threads[i].Name = "Child Thread " + i;
            }
            foreach (Thread t in Threads)
            {
                t.Start();
            }
            Console.ReadLine();
            #endregion

            Console.Read();

        }

        //Callback method and the signature should be the same as the callback delegate signature
        public static void ResultCallBackMethod(int Result)
        {
            Console.WriteLine("The Result is " + Result);
        }

    }
}
