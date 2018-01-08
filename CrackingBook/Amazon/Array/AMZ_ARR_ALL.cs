using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Amazon.Array
{

    public class AMZ_ARR_ALL
    {
        //http://www.geeksforgeeks.org/find-duplicates-in-on-time-and-constant-extra-space/
        public void findDuplicates(int[] arr, int size)
        {
            int i;
            Console.WriteLine("The repeating elements are : ");

            for (i = 0; i < size; i++)
            {
                if (arr[Math.Abs(arr[i])] >= 0)
                    arr[Math.Abs(arr[i])] = -arr[Math.Abs(arr[i])];
                else
                    Console.WriteLine(Math.Abs(arr[i]) + " ");
            }
        }

        //Longest one/zero sequence in 2d array - MS Interview
        public void LongestSequence(string binaryString)
        {
            int max0Seq = 0;
            int max1Seq = 0;
            int tempmax1Seq = 0;
            int tempmax0Seq = 0;
            var arr = binaryString.Split(' ');
            for (var i = 0; i < arr.Length; i++) //0001101
            {
                if (arr[i] == "1")
                {
                    tempmax1Seq++;
                    tempmax0Seq = 0;
                    if (max1Seq < tempmax1Seq)
                    {
                        max1Seq = tempmax1Seq;
                    }
                }
                else
                {
                    tempmax0Seq++;
                    tempmax1Seq = 0;
                    if (max0Seq < tempmax0Seq)
                    {
                        max0Seq = tempmax0Seq;
                    }
                }

            }
            Console.WriteLine("Max no of 1 seq : " + max1Seq);
            Console.WriteLine("Max no of 0 seq : " + max0Seq);
        }
        //http://www.geeksforgeeks.org/binary-search/
        public void BinarySearch(int[] arr, int key)
        {
            Console.WriteLine(search(arr, 0, arr.Length - 1, key));
        }

        public int search(int[] arr, int left, int right, int key)
        {
            if (right >= 1)
            {
                int mid = left + ((right - left) / 2);
                if (arr[mid] == key)
                {
                    return mid;
                }

                if (arr[mid] > key)
                {
                    return search(arr, left, mid - 1, key);
                }

                if (arr[mid] < key)
                {
                    return search(arr, mid + 1, right, key);
                }

            }
            return -1;
        }
    }
}

