using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Arrays
{
    public class FindOrderBreaker
    {
        static void Main(string[] args)
        {
            var arr = "1,2,3,4,5,-2,7,18,9,12".Split(',');
            var intArr = Array.ConvertAll(arr, Int32.Parse);
            FindIndex(intArr);
        }

        static void FindIndex(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (i != 0 && input[i-1] > input[i]) {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine(0);
        }

       
    }
}
