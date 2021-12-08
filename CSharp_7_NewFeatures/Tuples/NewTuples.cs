using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_7_NewFeatures.Tuples
{
    public class NewTuples
    {
        /*
         * Tuples in C# 7 are values, so they are copied by value, rather than by reference.
         * 
         * 
         * 
         */
        public static (int count, double sum) Calulate(IEnumerable<double> values)
        {
            int count = 0;
            double sum = 0.0;
            foreach (var value in values)
            {
                count++;
                sum += value;
            }
            return (count, sum);
        }


        public static (string, double, string, string) GetEmployeeDetails()
        {
            string EmployeeName = "Mahmoud";
            double Salary = 2000;
            string Gender = "Male";
            string Department = "IT";
            return (EmployeeName, Salary, Gender, Department);
        }
    }
}
