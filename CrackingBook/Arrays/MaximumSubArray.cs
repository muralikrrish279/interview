using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Arrays
{
    class MaxSubArray   
    {

        public static void find()
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
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
