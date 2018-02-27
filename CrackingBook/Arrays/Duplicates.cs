using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Array
{

    public class Duplicates
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

       
    }
}

