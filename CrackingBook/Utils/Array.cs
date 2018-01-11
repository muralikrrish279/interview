using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Utils
{
    public static class ArrayUtil
    {
        public static void printArray<T>(T[] input)
        {
            foreach (var item in input)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
