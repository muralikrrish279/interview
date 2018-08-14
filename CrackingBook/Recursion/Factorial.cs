using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Recursion
{
    class Factorial
    {
        //static void Main(string[] args)
        //{
        //    //var value = Calc(3);
        //    var value = fibonacci(9);

        //    Console.WriteLine(value);
        //}

        public static int Calc(int n) //abc
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return Calc(n - 1) * n;
            }

        }

        public static int fibonacci(int n) //abc
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return fibonacci(n - 1) + fibonacci(n - 2);
            }

        }
    }
}
