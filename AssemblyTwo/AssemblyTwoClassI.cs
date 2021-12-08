using AssemblyOne;
using System;

namespace AssemblyTwo
{
    public class AssemblyTwoClassI :AssemblyOneClassI
    {
        public void Test()
        {
            //AssemblyOneClassI instance = new AssemblyOneClassI();
            Console.WriteLine(ID);
        }
    }
}
