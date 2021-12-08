using CSharp_7_NewFeatures.PatternMatching;
using CSharp_7_NewFeatures.Tuples;
using System;
using System.Collections.Generic;

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
            (string Name, double Salary, string Gender, string Dept) = NewTuples.GetEmployeeDetails();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
