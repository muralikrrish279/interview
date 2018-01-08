using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.HackerRank.WarmUp
{
    //    Given an array of integers, calculate which fraction of its elements are positive, which fraction of its elements are negative, and which fraction of its elements are zeroes, respectively. Print the decimal value of each fraction on a new line.

    //Note: This challenge introduces precision problems.The test cases are scaled to six decimal places, though answers with absolute error of up to are acceptable.

    //Input Format

    //The first line contains an integer, , denoting the size of the array.
    //The second line contains  space-separated integers describing an array of numbers.

    //Output Format

    //You must print the following lines:

    //A decimal representing of the fraction of positive numbers in the array.
    //A decimal representing of the fraction of negative numbers in the array.
    //A decimal representing of the fraction of zeroes in the array.
    //Sample Input

    //6
    //-4 3 -9 0 4 1         
    //Sample Output

    //0.500000
    //0.333333
    //0.166667
    //Explanation

    //There are positive numbers, negative numbers, and zero in the array. 
    //The respective fractions of positive numbers, negative numbers and zeroes are , and , respectively
    class FractionNumbers
    {
        public void Find()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int positives = 0;
            int negatives = 0;
            int zeros = 0;
            foreach (var item in arr)
            {
                if (item > 0)
                    positives += 1;
                else if (item < 0)
                    negatives += 1;
                else
                    zeros += 1;
            }

            Console.WriteLine((double)positives / n);
            Console.WriteLine((double)negatives / n);
            Console.WriteLine((double)zeros / n);
        }
    }
}

