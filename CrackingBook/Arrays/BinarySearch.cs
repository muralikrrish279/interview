using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Arrays
{


    public class BinarySearchInArray
    {
        //static void Main(string[] args)
        //{
        //    //var intArr = new int[] { 2, 4, 5, 7, 9, 11, 18, 19, 20 };
        //    //Recursive(intArr, 20);
        //    //var intArr = new int[] { 2, 4, 5, 7, 9, 11, 18, 19, 20 };
        //    //Iterative(intArr, 20);

        //    //var intArr = new int[] { 1, 2, 10, 10, 10, 11, 12 };
        //    //FirstOccurence(intArr, 10);

        //    var intArr = new int[] { 1, 2, 10, 10, 10, 11, 12 };
        //    LastOccurence(intArr, 10);
        //}

        static void Recursive(int[] input, int target)
        {
            RecursiveHelper(input, 0, input.Length - 1, target);

        }

        static void RecursiveHelper(int[] input, int low, int high, int target)
        {
            if (low > high)
            {
                Console.WriteLine("Not Found");
                return;
            }

            int mid = (low + high) / 2;
            if (input[mid] == target)
            {
                Console.WriteLine("Found");
                return;
            }
            else if (input[mid] > target)
            {
                RecursiveHelper(input, low, mid - 1, target);
            }
            else
            {
                RecursiveHelper(input, mid + 1, high, target);
            }

        }

        static void Iterative(int[] input, int target)
        {
            int low = 0;
            int high = input.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (input[mid] == target)
                {
                    Console.WriteLine("Found");
                    return;
                }
                else if (input[mid] > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            Console.WriteLine("Not Found");
        }

        static void FirstOccurence(int[] input, int target)
        {
            int low = 0;
            int high = input.Length - 1;
            int result = -1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (input[mid] == target)
                {
                    result = mid;
                    high = mid - 1; // First occurence then go left
                }
                else if (input[mid] > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            Console.WriteLine(result);
        }

        static void LastOccurence(int[] input, int target)
        {
            int low = 0;
            int high = input.Length - 1;
            int result = -1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (input[mid] == target)
                {
                    result = mid;
                    low = mid + 1; // last occurence then go right
                }
                else if (input[mid] > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            Console.WriteLine(result);
        }


    }
}
