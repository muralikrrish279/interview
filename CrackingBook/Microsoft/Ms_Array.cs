using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Microsoft
{
    public class Ms_Array
    {

        public T[] Reverse<T>(T[] input) {
            if (input.Length < 1) {
                return input;
            }
            var start = 0;
            var end = input.Length - 1;
            while (end > 0)
            {
                T temp = input[end];
                input[end] = input[start];
                input[start] = temp;
                start++;
                end--;
            }
            return input;
        }

        public void printArray<T>(T[] input) {
            foreach (var item in input)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
