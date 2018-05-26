using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook
{
	////Cracking Book - 16.6
    class SmallestDiff
    {
      
   //     static void Main(string[] args)
   //     {
			//FindDiff(new int[] { 1, 3,15,11,2 }, new int[] {23,127,235,19,8});
        //}

        private static void FindDiff(int[] arr1, int[] arr2)
        {
			System.Array.Sort(arr1);
			System.Array.Sort(arr2);

			int a = 0;
			int b = 0;
			int diff = int.MaxValue;
            while (arr1.Length > a && arr2.Length > b)
			{
				var temp = Math.Abs(arr1[a] - arr2[b]);
				if(temp < diff){
					diff = temp;
				}

				if(arr1[a] < arr2[b]){
					a++;
				}else{
					b++;
				}
			}

			Console.WriteLine(diff);
        }
    }
}
