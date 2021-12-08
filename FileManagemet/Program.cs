using FileManagemet.Helpers;
using System;

namespace FileManagemet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            File.Delete(@"F:\Other Companies\NewHorizon\cis-app\src\app\");
        }
    }
}
