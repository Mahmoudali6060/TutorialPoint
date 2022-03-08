using Collections.List;
using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployees = EmpHelper.GetEmployees();
            //TrueForAll
            Console.WriteLine("Are all salaries greater than 5000: "
                            + listEmployees.TrueForAll(x => x.Salary > 5000));


            // ReadOnlyCollection will not have Add() or Remove() methods
            System.Collections.ObjectModel.ReadOnlyCollection<Employee>
                            readOnlyEmployees = listEmployees.AsReadOnly();
            Console.WriteLine("Total Items in ReadOnlyCollection = " +
                                       readOnlyEmployees.Count);


            // listEmployees list is created with an initial capacity of 50
            // but only 4 items are in the list. The filled percentage is 
            // less than 90 percent threshold.
            Console.WriteLine("List capacity before invoking TrimExcess = " +
                            listEmployees.Capacity);


            // Invoke TrimExcess() to set the capacity to the actual 
            // number of elements in the List
            listEmployees.TrimExcess();

            Console.WriteLine("List capacity After invoking TrimExcess = " +
                           listEmployees.Capacity);

            Console.ReadKey();


        }
    }
}
