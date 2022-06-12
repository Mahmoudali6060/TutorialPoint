using System;
using System.Collections.Generic;
using System.Text;

namespace Multi_Threading.Helper
{
    // First Create the callback delegate with the same signature of the callback method.
    public delegate void ResultCallbackDelegate(int Results);

    public class DataRetrieving
    {
        
        //Creating two private variables to hold the Number and ResultCallback instance
        private int _Number;
        private ResultCallbackDelegate _resultCallbackDelegate;

        //Initializing the private variables through constructor
        //So while creating the instance you need to pass the value for Number and callback delegate
        public DataRetrieving(int Number, ResultCallbackDelegate resultCallbackDelagate)
        {
            _Number = Number;
            _resultCallbackDelegate = resultCallbackDelagate;
        }

        //This is the Thread function which will calculate the sum of the numbers
        public void CalculateSum()
        {
            int Result = 0;
            for (int i = 1; i <= _Number; i++)
            {
                Result = Result + i;
            }
            //Before the end of the thread function call the callback method
            if (_resultCallbackDelegate != null)
            {
                _resultCallbackDelegate(Result);
            }
        }
    }
}
