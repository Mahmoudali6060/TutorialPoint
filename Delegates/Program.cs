using Delegates.Helpers;
using Delegates.Models;
using System;
using System.Collections.Generic;
using static Delegates.Helpers.EmployeeHelper;

namespace Delegates
{
    class Program
    {
        //Defining Delegates
        //Note: The access specifeis, return type and the number, order and type of parameters of delegate
        //should be same as the function it refers to.
        public delegate void AddDelegate(int a, int b);
        public delegate string GreetingsDelegate(string name);
        public delegate void RectangleDelete(double Width, double Height);

        static void Main(string[] args)
        {
            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Single Delegate
            //DelegateHelpers obj = new DelegateHelpers();
            ////Instantiating delegate by passing the target function Name
            ////The Add method is non static so here we are calling method using object
            //AddDelegate ad = new AddDelegate(obj.Add);
            ////Greetings method is static so here we are callling the method by using the class name
            //GreetingsDelegate gd = new GreetingsDelegate(DelegateHelpers.Greetings);
            ////Invoking The Delegates
            //ad(100, 50);
            //string GreetingsMessage = gd("Pranaya");
            ////We can also use Invoke method to execute delegates
            //// ad.Invoke(100, 50);
            //// string GreetingsMessage = gd.Invoke("Pranaya");
            //Console.WriteLine(GreetingsMessage);
            //Console.ReadKey();

            //Rectangle rect = new Rectangle();
            //rect.GetArea(23.45, 67.89);
            //rect.GetPerimeter(23.45, 67.89);
            //Console.ReadKey();

            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Multi cast Delegate
            //Rectangle rect = new Rectangle();
            //RectangleDelete rectDelegate = new RectangleDelete(rect.GetArea);

            ////Adding a method to delegate object
            //rectDelegate += rect.GetPerimeter;
            //rectDelegate(23.45, 67.89);
            //Console.WriteLine();
            //rectDelegate.Invoke(13.45, 76.89);

            //Console.WriteLine();
            ////Removing a method from delegate object
            //rectDelegate -= rect.GetPerimeter;
            //rectDelegate.Invoke(13.45, 76.89);

            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Real Example-Delegate
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Male",
                Experience = 5,
                Salary = 10000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Experience = 10,
                Salary = 20000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Anurag",
                Experience = 15,
                Salary = 30000
            };

            List<Employee> lstEmployess = new List<Employee>();
            lstEmployess.Add(emp1);
            lstEmployess.Add(emp2);
            lstEmployess.Add(emp3);


            EligibleToPromotion eligibleTopromote = new EligibleToPromotion(EmployeeHelper.Promote);
            EmployeeHelper.PromoteEmployee(lstEmployess, eligibleTopromote);
            Console.ReadKey();

        }
    }
}
