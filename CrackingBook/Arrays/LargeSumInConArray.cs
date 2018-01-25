using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Arrays
{

    //https://www.geeksforgeeks.org/largest-sum-contiguous-subarray/
    public class LargeSumInConArray
    {
        //static void Main(string[] args)
        //{
        //    var intArr = new int[] { -2, -3, 4, -1, -2, 1, 5, -3 };
        //    FindSum(intArr);
        //}

        static void FindSum(int[] input)
        {
            int currMax = 0;
            int globalMax = 0;
            for (int i = 0; i < input.Length; i++)
            {
                currMax = Math.Max(input[i], currMax + input[i]);
                globalMax = Math.Max(currMax, globalMax);

            }

            Console.WriteLine("Maximum Sum Is " + globalMax);

        }


    }
}
