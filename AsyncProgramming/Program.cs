using AsyncProgramming.Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncProgramming
{
    class Program
    {
        //Allowing Maximum 3 tasks to be executed at a time
        static SemaphoreSlim semaphoreSlim = new SemaphoreSlim(3);
        static void Main(string[] args)
        {
            #region Introduction to Async-Await
            //Console.WriteLine("Main Method Started......");
            //SomeMethod();
            //Console.WriteLine("Main Method End");
            //Console.ReadKey();
            #endregion

            #region Concurrent Tasks

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine($"Main Thread Started");
            List<CreditCard> creditCards = CreditCard.GenerateCreditCards(100000);
            Console.WriteLine($"Credit Card Generated : {creditCards.Count}");

            ProcessCreditCards(creditCards);

            Console.WriteLine($"Main Thread Completed");
            stopwatch.Start();
            Console.WriteLine($"Main Thread Execution Time {stopwatch.ElapsedMilliseconds / 1000.0} Seconds");
            Console.ReadKey();
            #endregion


        }


        #region Introduction to Async-Await
        public async static void SomeMethod()
        {
            Console.WriteLine("Some Method Started......");
            //Thread.Sleep(TimeSpan.FromSeconds(10));
            //await Task.Delay(TimeSpan.FromSeconds(10));
            //Wait();
            //Console.WriteLine("\n");

            var GreetingSMessage = await Greetings("Salman");
            Console.WriteLine($"\n{GreetingSMessage}");
            Console.WriteLine("Some Method End");
        }

        public static async Task<string> Greetings(string Name)
        {
            string message = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44324/");

                HttpResponseMessage response = await client.GetAsync($"api/greetings/{Name}");
                message = await response.Content.ReadAsStringAsync();
            }
            return message;
        }

        private static async Task Wait()
        {
            await Task.Delay(TimeSpan.FromSeconds(10));
            Console.WriteLine("\n10 Seconds wait Completed\n");
        }

        #endregion

        #region Concurrent Tasks
        public static async void ProcessCreditCards(List<CreditCard> creditCards)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var tasks = new List<Task<string>>();

            //Need to use async lambda expression
            tasks = creditCards.Select(async card =>
            {
                //This will tell if we have more than 4000 tasks are running, 
                //we are going to wait and '
                //we're going to wait until the semaphore gets released.
                await semaphoreSlim.WaitAsync();
                //Need to use await operator here as we are using asynchronous WaitAsync
                try
                {
                    return await ProcessCard(card);
                }
                finally
                {
                    //Release the semaphore
                    semaphoreSlim.Release();
                }

            }).ToList();

            //It will execute all the tasks concurrently
            await Task.WhenAll(tasks);
            stopwatch.Stop();
            Console.WriteLine($"Processing of {creditCards.Count} Credit Cards Done in {stopwatch.ElapsedMilliseconds / 1000.0} Seconds");
        }

        public static async Task<string> ProcessCard(CreditCard creditCard)
        {
            await Task.Delay(1000);
            string message = $"Credit Card Number: {creditCard.CardNumber} Name: {creditCard.Name} Processed";
            return message;
        }
        #endregion

    }
}
