using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook
{
    //https://www.geeksforgeeks.org/count-triplets-with-sum-smaller-that-a-given-value/
    public class CountTriplets
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(CountTrps(new int[] { 5, 1, 3, 4, 7 },12));
        //}
        static int CountTrps(int[] arr,int target)
        {
            var output = 0;
            System.Array.Sort(arr);
            for (int i = 0; i < arr.Length - 2; i++)
            {
                var j = i + 1;
                var k = arr.Length - 1;
                while (j < k)
                {
                    if (arr[i] + arr[j] + arr[k] >= target)
                    {
                        k--;
                        //Move Right
                    }
                    else {
                        //Move left
                        output += k - j;
                        j++;
                    }

                }
            }
            return output;
        }
    }
}
