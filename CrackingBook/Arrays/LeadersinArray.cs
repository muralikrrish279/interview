using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook
{
    //https://www.geeksforgeeks.org/leaders-in-an-array/
    class LeadersinArray
    {

        public static void find(int[] arr)
        {
            int length = arr.Length;
            int max = 0;
            
            for (var i = length - 1; i >=0; i--) {
                if (max < arr[i]) {
                    max = arr[i];
                    Console.WriteLine(max);
                }
            }

        }

        //static void Main(string[] args)
        //{
        //    int[] arr = new int[] { 16, 17, 4, 3, 5, 2 }; //answer : 17 5 2
        //    find(arr);
        //}
    }
}
