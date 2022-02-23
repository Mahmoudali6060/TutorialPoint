using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_7_NewFeatures.ExpressionBodiedMembers
{
    public class Employee
    {


        /*
        Generally, expression-bodied methods are more used than other members. They have the following characteristics:
            [1]Expression bodied methods can specify all the accessibility operators i.e. public, protected, internal, private, and protected internal.
            [2]These can be declared virtual or abstract or can even override a base class method.
            [3]Such methods can be static.
            [4]Methods can even exhibit asynchronous behavior, if they return void, Task or Task<T>.
         */
        private string FirstName;
        private string LastName;

        //Expression Bodied Constructor
        public Employee(string name) => FirstName = name;

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        //Note: This removes not only the curly brackets but also the return keyword. Return is implicit with a lambda expression
        public string GetFullName() => $"{FirstName} {LastName}";
        public override string ToString() => $"{FirstName} {LastName}";
        public void DisplayName() => Console.WriteLine(GetFullName());


        //Expression-Bodied Destructors
        ~Employee() => Console.WriteLine($"The {ToString()} destructor is executing.");
    }
}
