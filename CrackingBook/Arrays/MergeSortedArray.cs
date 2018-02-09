using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Arrays
{
    public class MergeSortedArray
    {

        //static void Main(string[] args)
        //{
        //    Merge(new int[] { 3, 27, 38, 43 }, new int[] { 9, 10, 11,14,29,90 });
        //}

        static void Merge(int[] arr1, int[] arr2)
        {
            var i = 0;
            var j = 0;
            var mergedIndex = 0;
            var n1 = arr1.Length;
            var n2 = arr2.Length;
            var merged = new int[n1 + n2];

            while (i < arr1.Length && j < arr2.Length) {
                if (arr1[i] < arr2[j]) {
                    merged[mergedIndex] = arr1[i];
                    i++;
                }
                else {
                    merged[mergedIndex] = arr2[j];
                    j++;
                }
                mergedIndex++;
            }

            while (i < arr1.Length)
            {
                merged[mergedIndex] = arr1[i];
                i++;
                mergedIndex++;
            }

            while (j < arr2.Length)
            {
                merged[mergedIndex] = arr2[j];
                j++;
                mergedIndex++;
            }

            foreach (var item in merged)
            {
                Console.WriteLine(item);
            }

        }
    }
}
