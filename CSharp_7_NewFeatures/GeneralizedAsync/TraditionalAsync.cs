using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_7_NewFeatures.GeneralizedAsync
{
    /*
     * If you have worked with the async methods, then you may know the async methods can have the following return types:
        [1]>>Task<TResult>, this return type is used when the async method returns a value.
        [2]>>Task, this return type is used when the async method does not return any value.
        [3]>>void, this return type is used for an event handler
     */
    public class TraditionalAsync
    {
        #region [1]>>Task<TResult>, this return type is used when the async method returns a value.
        public async Task<string> ShowTodaysInfo()
        {
            var leisureHours = GetLeisureHours();
            string result = $"Today is {DateTime.Today:D}\n" +
                         "Today's hours of leisure: " +
                         $"{await leisureHours}";
            return result;
        }
        public async Task<int> GetLeisureHours()
        {
            // Task.FromResult is a placeholder for actual work that returns a string.  
            var today = await Task.FromResult<string>(DateTime.Now.DayOfWeek.ToString());
            // The method then can process the result in some way.  
            int leisureHours;
            if (today.First() == 'S')
                leisureHours = 16;
            else
                leisureHours = 5;
            return leisureHours;
        }
        #endregion


        #region [2]>>Task, this return type is used when the async method does not return any value.
        public async Task DisplayCurrentInfo()
        {
            await WaitAndApologize();
            Console.WriteLine($"Today is {DateTime.Now:D}");
            Console.WriteLine($"The current time is {DateTime.Now.TimeOfDay:t}");
            Console.WriteLine("The current temperature is 76 degrees.");
        }
        public async Task WaitAndApologize()
        {
            // Task.Delay is a placeholder for actual work.  
            await Task.Delay(2000);
            // Task.Delay delays the following line by two seconds.  
            Console.WriteLine("\nSorry for the delay. . . .\n");
        }
        #endregion
    }
}
