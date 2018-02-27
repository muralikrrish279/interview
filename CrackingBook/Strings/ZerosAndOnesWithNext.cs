using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook
{
    class ZerosAndOnesWithNext
    {      

        //11001100110000 // every pass replace 0 with 1 if next element is 1
        //how many pass to get to all 1's
        public int find(string input)
        {
            var arr = input.ToCharArray();
            int ones = 0;
            int zeros = 0;
            int counter = 0;
            foreach (var item in arr)
            {
                if (item == '1')
                {
                    ones++;
                }
                else
                {
                    zeros++;
                }
            }
            while (zeros > 0) {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == '0')
                    {
                        if (arr[i + 1] == '1')
                        {
                            arr[i] = '1';
                            zeros--;
                        }
                    }
                }
                counter++;
            }
            
            return counter;
        }
    }
}
