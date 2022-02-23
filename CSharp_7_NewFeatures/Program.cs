using CSharp_7_NewFeatures.GeneralizedAsync;
using CSharp_7_NewFeatures.PatternMatching;
using CSharp_7_NewFeatures.RefLocalRefReturn;
using CSharp_7_NewFeatures.ThrownExpression;
using CSharp_7_NewFeatures.Tuples;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp_7_NewFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            //>>>>>>>>>>>>>>>>Out Variables<<<<<<<<<<<<<<<<<<<<<<//
            //OutVariables.OutVariables.GetEmployeeDetails(out var EmployeeName, out string Gender, out long Salary, out string Department);
            //Console.WriteLine("Employee Details:");
            //Console.WriteLine("Name: {0}, Gender: {1}, Salary: {2}, Department: {3}",
            //EmployeeName, Gender, Salary, Department);
            //>>>>>>>>>>>>>>>>End Out Variables<<<<<<<<<<<<<<<<<<<<<<//


            //>>>>>>>>>>>>>>Pattern Matching<<<<<<<<<<<<<<<<<<<<<//
            //Circle circle = new Circle(10);
            //PattenMatchingHelper.DisplayArea(circle);
            //Rectangle rectangle = new Rectangle(10, 5);
            //PattenMatchingHelper.DisplayArea(rectangle);
            //Triangle triangle = new Triangle(10, 5);
            //PattenMatchingHelper.DisplayArea(triangle);
            //>>>>>>>>>>>>>>End Pattern Matching<<<<<<<<<<<<<<<<<<<<<//


            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Digit Seperator
            //DigitSeperator.DigitSeperator.PrintLongNumber();
            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>End Digit Seperator

            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Splitting Tuples
            //(string Name, double Salary, string Gender, string Dept) = NewTuples.GetEmployeeDetails();
            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>End Splitting Tuples

            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Ref local-Ref Return

            //[1] >>>Ref Local
            //int no1 = 1;
            //ref int no2 = ref no1;
            //no2 = 2;
            //Console.WriteLine($"local variable {nameof(no1)} after the change: {no1}");

            ////[2] >>>Ref Return

            //int[] x = { 2, 4, 62, 54, 33, 55, 66, 71, 92 };
            //ref int oddNum = ref RefReturn.GetFirstOddNumber(x); //storing as reference  
            //Console.WriteLine($"\t\t{oddNum}");
            //oddNum = 35;
            //for (int i = 0; i < x.Length; i++)
            //{
            //    Console.Write($"{x[i]}\t");
            //}
            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>End Ref Local-Ref Return

            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Generalized Async Return Types
            /*
            [1]>> Task<TResult>, this return type is used when the async method returns a value.
            [2]>> Task, this return type is used when the async method does not return any value.
            [3] >> void, this return type is used for an event handler
            */

            //TraditionalAsync traditionalAsync = new TraditionalAsync();

            // //[1]>> Task<TResult>, this return type is used when the async method returns a value.
            // //Console.WriteLine(generalizedAsync.ShowTodaysInfo().Result);


            // //[2]>> Task, this return type is used when the async method does not return any value.
            // Console.WriteLine(traditionalAsync.DisplayCurrentInfo());

            // //[3] >> void, this return type is used for an event handler
            // RunCounter().Wait();
            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>END Generalized Async Return Types


            var a = Expression.Divide(10, 0);
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static async Task RunCounter()
        {
            var count = new Counter(5);
            await count.StartCounting(8);
        }
    }
}
