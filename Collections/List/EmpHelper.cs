using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.List
{
    public class EmpHelper
    {

        public static List<Employee> GetEmployees()
        {
            Employee emp1 = new Employee()
            {
                Id = 101,
                Name = "Pranaya",
                Gender = "Male",
                Salary = 5000
            };
            Employee emp2 = new Employee()
            {
                Id = 102,
                Name = "Priyanka",
                Gender = "Female",
                Salary = 7000
            };
            Employee emp3 = new Employee()
            {
                Id = 103,
                Name = "Anurag",
                Gender = "Male",
                Salary = 4500
            };
            Employee emp4 = new Employee()
            {
                Id = 104,
                Name = "Sambit",
                Gender = "Male",
                Salary = 6500
            };

            List<Employee> listEmployees = new List<Employee>(100);
            listEmployees.Add(emp1);
            listEmployees.Add(emp2);
            listEmployees.Add(emp3);
            listEmployees.Add(emp4);

            return listEmployees;
        }
    }
}