using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook
{
	//Cracking book - 16.21
	public class SumSwap
	{
		private static void Sort(int[] arr1, int[] arr2)
		{
			System.Array.Sort(arr1);
			System.Array.Sort(arr2);
			var sum1 = Sum(arr1);
			var sum2 = Sum(arr2);
			var targt = target(sum1, sum2);
			var a = 0;
			var b = 0;
			while (a < arr1.Length && b < arr2.Length)
			{
				var diff = arr1[a] - arr2[b];
				if(diff == targt){
					Console.WriteLine($"{arr1[a]} {arr2[b]}");
					return;
				}

				if(arr1[a] < arr2[b]){
					a++;
				}else{
					b++;
				}
			}
			Console.WriteLine("Arrays cannot be balanced");
		}

		private static int target(int sum1, int sum2)
        {
			if(((sum1 - sum2) % 2 != 0)){
				throw new InvalidOperationException();
			}
			return (sum1 - sum2) / 2;
        }

		private static int Sum(int[] arr)
        {
			var result = 0;
            foreach (var item in arr)
			{
				result += item;
			}
			return result;
		}


		//static void Main(string[] args)
		//{
		//	Sort(new int[] { 4, 1, 2, 1, 1, 2 }, new int[] { 3, 6, 3, 3 });
		//}


	}
}

