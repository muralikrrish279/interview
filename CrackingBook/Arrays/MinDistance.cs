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
        //    var intArr = new int[] { 2, 5, 3, 5, 4, 4, 2, 3 };
        //    FindMinDist(intArr, 3, 2);
        //}

        static void FindMinDist(int[] input, int x, int y)
        {
            var prev = -1;
            var dist = int.MaxValue;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == x || input[i] == y)
                {
                    prev = i;
                    break;
                }
            }

            for (int i = prev + 1; i < input.Length; i++)
            {
                if (input[i] == x || input[i] == y)
                {
                    if (input[prev] == input[i])
                    {
                        prev = i;
                    }
                    else
                    {
                        dist = Math.Min(Math.Abs(i - prev), dist);
                        prev = i;
                    }
                }

            }
            Console.WriteLine(dist);

        }
    }
}
