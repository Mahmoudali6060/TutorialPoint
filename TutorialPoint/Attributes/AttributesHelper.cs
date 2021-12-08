
#define DEBUG

using System;
using System.Diagnostics;

namespace TutorialPoint.Attributes
{
    public class Conditional
    {
        [Conditional("TRAC")]
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class ConditionalTest
    {
        public static void PrintId(string message)
        {
            Conditional.PrintMessage(message);
            PrintName("Mahmoud !!");
        }
        public static void PrintName(string message)
        {
            Conditional.PrintMessage(message);
        }
    }
}



