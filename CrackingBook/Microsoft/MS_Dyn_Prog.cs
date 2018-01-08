using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Microsoft
{
    public class MS_Dyn_Prog
    {
        //Find a magic index A[i] = i in a sorted interger array
        //Sub : Problem - what is values are not unique
        public int MagicIndex(int[] input, bool IsArrayUnique)
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

        public int MagicIndexForUnique(int[] input, int start, int end)
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
        public int MagicIndexWithNoUnique(int[] input, int start, int end)
        {
            return -1;
        }
    }
}
