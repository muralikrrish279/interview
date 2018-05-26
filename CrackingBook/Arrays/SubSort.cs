using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook
{
	//Cracking book 16.16
    class SubSort
    {

        private static void Sort(int[] arr1)
        {
			var leftEnd = FindLeftEndLimit(arr1);
			if(leftEnd == -1){
				Console.WriteLine("Array already sorted");
				return;
			}

			var startRight = FindRightStartLimit(arr1);


			var leftIndex = ShrinkLeft(arr1, leftEnd, startRight);

			Console.WriteLine(leftIndex);

			var rightIndex = ShrinkRight(arr1, startRight, leftEnd);
			Console.WriteLine(rightIndex);
        }
        
   //     static void Main(string[] args)
   //     {
   //         //Sort(new int[] { 1, 2, 4,7,10,11,8,12,5,6,16,18,19 });
			////Sort(new int[] { 1,2,3,4,5,6,7,8,9});
        //}

        private static int FindLeftEndLimit(int[] arr1)
        {
            for (int i = 1; i < arr1.Length; i++)
			{
				if(arr1[i-1] > arr1[i]){
					return i - 1;
				}
			}
			return -1;
		}

		private static int FindRightStartLimit(int[] arr1)
        {
			for (int i = arr1.Length - 1; i >= 0; i--)
            {
                if (arr1[i - 1] > arr1[i])
                {
                    return i;
                }
            }
            return -1;
        }

		private static int ShrinkLeft(int[] arr1,int start,int rightMin)
        {
			var rightminvalue = arr1[rightMin];
            for (int i = start; i >= 0; i--)
            {
				if (arr1[i] < rightminvalue)
                {
                    return i+1;
                }
            }
            return -1;
        }

		private static int ShrinkRight(int[] arr1, int start, int leftMax)
        {
			var leftMaxValue = arr1[leftMax];
            for (int i = start; i < arr1.Length; i++)
            {
				if (arr1[i] > leftMaxValue)
                {
                    return i-1;
                }
            }
            return -1;
        }
    }
}
