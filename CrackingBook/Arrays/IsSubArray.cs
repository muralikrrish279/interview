using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook
{
    class IsSubArray
    {

        public static bool isSub(int[] arr1, int[] arr2)
        {
            if (arr2.Length > arr2.Length)
            {
                return false;
            }

            var startIndex = BinarySearch(arr1, 0, arr1.Length - 1, arr2[0]);
            if (startIndex == -1) {
                return false;
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] != arr1[startIndex++])
                {
                    return false;
                }
                else {
                    if (i == arr2.Length - 1) {
                        return true;
                    }
                }
            }

            return false;

        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(isSub(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 9,7,8 }));
        //}

        private static int BinarySearch(int[] arr1, int low, int high, int target)
        {
            if (low < high) {
                var mid = (low + high) / 2;

                if (arr1[mid] == target)
                {
                    return mid;
                }
                else if (arr1[mid] > target)
                {
                    return BinarySearch(arr1, low, mid - 1, target);
                }
                else {
                    return BinarySearch(arr1, mid+1, high, target);
                }
            }
            return -1;
        }
    }
}
