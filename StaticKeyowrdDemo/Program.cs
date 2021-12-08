using System;

namespace StaticKeyowrdDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person C1 = new Person();
            //C1.FirstName = "Pranaya";
            //C1.LastName = "Rout";

            ////Person C2 = C1;

            //Person C2 = new Person();
            //C2.FirstName = "Pranaya";
            //C2.LastName = "Rout";

            //Console.WriteLine(C1 == C2);
            //Console.WriteLine(C1.Equals(C2));
            //Console.ReadKey();


            //object name = "sandeep";
            //char[] values = { 's', 'a', 'n', 'd', 'e', 'e', 'p' };
            //object myName = new string(values);
            //Console.WriteLine("== operator result is {0}", name == myName);//Reference
            //Console.WriteLine("Equals method result is {0}", myName.Equals(name));//Content
            Child child = new Child();
            child.GetName();
            Console.ReadKey();
        }
    }

    //Method Hiding
    public class Parent
    {
        public string GetName()
        {
            return "Parent";
        }
    }

    public class Child : Parent
    {
        public string GetName()
        {
            return "Child";
        }
      
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
