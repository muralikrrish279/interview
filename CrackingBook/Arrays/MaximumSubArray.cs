using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook
{
    class MaxSubArray   
    {

        public static void find()
        {
            int[] arr = new int[] { -2, -5, 6, -2, -3, 1, 5, -6 }; //answer must be 7
            int max_current = arr[0];
            int max_global = arr[0];

            for (var i = 1; i < arr.Length - 1; i++) { 
                max_current = Math.Max(arr[i], max_current + arr[i]);
                if (max_current > max_global) {
                    max_global = max_current;
                }
            }

            Console.WriteLine(max_global);

        }

        //static void Main(string[] args)
        //{
        //    find();
        //}
    }
}
