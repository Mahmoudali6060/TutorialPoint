using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExceptionHandling.Helpers
{
    public class OddNumberException : Exception
    {
        public override string Message
        {
            get
            {
                return "divisor cannot be odd number";
            }
        }
    }
}
