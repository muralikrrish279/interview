using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Arrays
{
    public class ReverseArray
    {

        public static T[] Reverse<T>(T[] input)
        {
            if (input.Length < 1)
            {
                return input;
            }
            var start = 0;
            var end = input.Length - 1;
            while (end > (input.Length - 1)/2)
            {
                T temp = input[end];
                input[end] = input[start];
                input[start] = temp;
                start++;
                end--;
            }
            return input;
        }


        //static void Main(string[] args)
        //{
        //    var reversed = Reverse(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
        //    Utils.ArrayUtil.printArray(reversed);
        //}
    }
}
