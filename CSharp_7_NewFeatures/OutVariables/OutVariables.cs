using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_7_NewFeatures.OutVariables
{
    public static class OutVariables
    {
        public static void GetEmployeeDetails(out string EmployeeName, out string Gender, out long Salary, out string Department)
        {
            EmployeeName = "Mahmoud";
            Gender = "Male";
            Salary = 20000;
            Department = "IT";
        }
    }
}
