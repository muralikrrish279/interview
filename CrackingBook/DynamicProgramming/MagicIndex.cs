using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook
{
    public class MagicIndex
    {
        //First occurence of magic index[where index and value is same]
        //static void Main(string[] args)
        //{
        //    //var output = MagicIndex1(new int[] { -2, -1, 0, 3, 5, 6, 7 });
        //    var output = MagicIndex1(new int[] { -10, -5, 2, 2, 2, 3, 4, 7, 9, 12, 13 }, false);

        //    Console.WriteLine(output);
        //}


        //Find a magic index A[i] = i in a sorted interger array
        //Sub : Problem - what is values are not unique
        public static int MagicIndex1(int[] input, bool IsArrayUnique = true)
        {
            if (input != null && input.Length < 0)
            {
                return -1;
            }
            if (IsArrayUnique)
            {
                return MagicIndexForUnique(input, 0, input.Length - 1);
            }
            else
            {
                return MagicIndexWithNoUnique(input, 0, input.Length - 1);
            }
        }

        public static int MagicIndexForUnique(int[] input, int start, int end)
        {
            if (end < start)
            {
                return -1;
            }
            var mid = (end + start) / 2;
            if (input[mid] == mid)
            {
                return mid;
            }
            else if (input[mid] < mid) //Go only right
            {
                return MagicIndexForUnique(input, mid + 1, end);
            }
            else
            {
                return MagicIndexForUnique(input, start, mid - 1);
            }
        }
        public static int MagicIndexWithNoUnique(int[] input, int start, int end)
        {
            if (end < start)
            {
                return -1;
            }
            var mid = (end + start) / 2;
            if (input[mid] == mid)
            {
                return mid;
            }

            var leftIndex = Math.Min(mid - 1, input[mid]); //Go Left
            var left = MagicIndexForUnique(input, start, leftIndex);
            if (left > 0)
                return left;

            var rightIndex = Math.Max(mid + 1, input[mid]); //Go Right
            var right = MagicIndexForUnique(input, rightIndex, end);
            return right;


        }
    }
}
