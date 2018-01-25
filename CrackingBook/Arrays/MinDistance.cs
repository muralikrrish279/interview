using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Arrays
{

    //https://www.geeksforgeeks.org/find-the-minimum-distance-between-two-numbers/
    public class MinDistance
    {
        //static void Main(string[] args)
        //{
        //    //var intArr = new int[] { 1, 2, 3, 4, 5, 5, 3, 2, 5 };
        //    //FindMinDist(intArr, 3, 5);
        //}

        static void FindMinDist(int[] input, int x, int y)
        {
            int globalCount = int.MaxValue;
            int currentCount = 0;
            int nextNumberToFind = 0;

            for (int i = 0; i < input.Length; i++)
            {
                

                if (input[i] == nextNumberToFind || input[i] == nextNumberToFind)
                {
                    if (globalCount < currentCount)
                    {
                        globalCount = currentCount;
                    }
                    currentCount = 0;
                }

                if (input[i] == x || input[i] == y)
                {
                    currentCount++;
                    nextNumberToFind = input[i] == x ? y : x;
                }
                else if (currentCount != 0)
                {
                    currentCount++;
                }

            }

            Console.WriteLine("Min Distance" + globalCount);



        }
    }
}
