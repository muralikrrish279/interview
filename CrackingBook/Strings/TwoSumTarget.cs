using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook
{

    //https://leetcode.com/problems/two-sum/description/
    public class TwoSumTarget
    {
        public static void DoWork(int[] arr, int target)
        {
            
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(target - arr[i])) {
                    Console.WriteLine(i.ToString() + dict[target - arr[i]].ToString());
                }
                if (!dict.ContainsKey(arr[i]))
                {
                    dict.Add(arr[i], i);
                }
            }
            
        }

        //static void Main(string[] args)
        //{
        //    DoWork(new int[] { 3,3}, 6);
        //}
    }
}
