using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Colleen is turning years old! She has  candles of various heights on her cake, and candle  has height.Because the taller candles tower over the shorter ones, Colleen can only blow out the tallest candles.

//Given the  for each individual candle, find and print the number of candles she can successfully blow out.


//Input Format


//The first line contains a single integer, , denoting the number of candles on the cake. 
//The second line contains  space-separated integers, where each integer describes the height of candle .


//Constraints

//Output Format

//Print the number of candles Colleen blows out on a new line.

//Sample Input 0

//4
//3 2 1 3
//Sample Output 0

//2
//Explanation 0

//We have one candle of height, one candle of height , and two candles of height.Colleen only blows out the tallest candles, meaning the candles where.Because there are  such candles, we print  on a new line.
namespace CrackingBook.Arrays
{
    class TallestCandles
    {
        public void FindTallestCandle()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] height_temp = Console.ReadLine().Split(' ');
            int[] height = System.Array.ConvertAll(height_temp, Int32.Parse);
          
            if (n < 1 || n > Math.Pow(10,5)) {
                Console.WriteLine("invalid input");
            }

            int highest = 0;
            int count = 0;
            for (var i = 0; i < n; i++)
            {
                if (height[i] < 1 || height[i] > Math.Pow(10, 7))
                {
                    Console.WriteLine("invalid input");
                }
                if (highest < height[i])
                {
                    highest = height[i];
                    count = 0;
                }
                if (highest == height[i])
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }
    }
}
