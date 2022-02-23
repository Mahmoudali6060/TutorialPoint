using CSharpExceptionHandling.Helpers;
using System;

namespace CSharpExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("ENTER TWO INTEGER NUMBERS:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            try
            {
                if (y % 2 > 0)
                {
                    //OddNumberException ONE = new OddNumberException();
                    //throw ONE;
                    throw new OddNumberException();
                }
                z = x / y;
                Console.WriteLine(z);
            }
            catch (OddNumberException one)
            {
                Console.WriteLine(one.Message);
            }


            try
            {
                throw new UserAlreadyLoggedInException("User Already logged in");
            }

            catch (UserAlreadyLoggedInException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("End of the program");
            Console.ReadKey();

        }
    }
}
