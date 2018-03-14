using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using CrackingBook.Utils;

namespace CrackingBook
{
    //Math.Pow
    public class MathPow
    {
        //public static int Power(int x,int n) /// O(n) solution
        //{
        //    if (n == 0)
        //        return 1;
        //    else if (n % 2 == 0) {
        //        return Power(x, n / 2) * Power(x, n / 2);
        //    } else {
        //        return x * Power(x, n / 2) * Power(x, n / 2);
        //    }
        //}

        public static int Power(int x, int n) /// O(log n) solution using memoization
        {
            int temp = 1;
            if (n == 0)
                return 1;

            temp = Power(x, n / 2);
            if (n % 2 == 0)
            {
                return temp * temp;
            }
            else
            {
                return x * temp * temp;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Power(2234, 4));
        }

    }
}
