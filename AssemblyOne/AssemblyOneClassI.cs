using System;

namespace AssemblyOne
{
    public class AssemblyOneClassI
    {
       internal protected int ID = 999;
    }
    public class AssemblyOneClassII
    {
        public void Test()
        {
            AssemblyOneClassI instance = new AssemblyOneClassI();
            // Can access inetrnal member ID as both AssemblyOneClassII and AssemblyOneClassI
            // are present in the same assembly            
            Console.WriteLine(instance.ID);
        }
    }
   
}
