using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Arrays
{

    //https://www.geeksforgeeks.org/find-subarray-least-average/
    public class MinAvgSubArray
    {
        //static void Main(string[] args)
        //{
        //    var intArr = new int[] { 3, 7, 90, 20, 10, 50, 40 };
        //    FindMinAvg(intArr, 2);
        //}

        static void FindMinAvg(int[] input, int k)
        {
            string range = "";
            int[] subArray = new int[k - 1];
            int globalSum = int.MaxValue;
            int currentSum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i % k < k)
                {
                    currentSum += input[i];
                }

                if (i % k == k - 1 && Math.Abs(currentSum / k) < Math.Abs(globalSum / k))
                {
                    range = "start : " + (i + 1 - k).ToString() + " End : " + i.ToString();
                    globalSum = currentSum;
                    currentSum = 0;
                }
            }

            Console.WriteLine("Minmum Avg Is " + Math.Abs(globalSum / k));
            Console.WriteLine("Index Range is  " + range);

        }


    }
}
