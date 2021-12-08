#define DEBUG
using System;
using System.Diagnostics;
using TutorialPoint.Attributes;

namespace TutorialPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Preprocessor Directives
            //#if DEBUG
#warning DO-To >> You must refactor this LATER  >>>Preprocessor Directives
            //#endif
            #endregion

            #region Attributes
            Conditional.PrintMessage("Hey !");
            ConditionalTest.PrintId("1");
            #endregion

            Console.WriteLine("Done !");

        }

        [Obsolete()]
        public static void Test()
        {
            Console.WriteLine("This method is depricated");
        }

    }
}
