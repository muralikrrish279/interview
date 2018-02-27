using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook
{
    public class HackerRank
    {

        //https://www.hackerrank.com/challenges/reduced-string/problem
        public void reducedstring()
        {
            string s = Console.ReadLine(); //aacdd
            var result = new StringBuilder("");
            var stck = new Stack<char>();
            foreach (var item in s)
            {
                var lastItme = stck.Count > 0 ? stck.Peek() : Convert.ToChar(" ");
                if (lastItme == item)
                {
                    stck.Pop();
                }
                else
                {
                    stck.Push(item);
                }
            }
            char[] reversed = stck.ToArray();
            System.Array.Reverse(reversed);
            var sb = new StringBuilder();
            for (int i = 0; i < reversed.Length; i++)
            {
                sb.Append(reversed[i]);
            }
            if (sb.Length <= 0)
            {
                Console.WriteLine("Empty String");
            }
            else
            {
                Console.WriteLine(sb.ToString());
            }
        }

        //https://www.hackerrank.com/challenges/camelcase/problem
        public void CamelCase()
        {
            string s = Console.ReadLine();
            int count = 1;
            foreach (var item in s)
            {
                if (item.ToString() == item.ToString().ToUpper())
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        //https://www.hackerrank.com/challenges/mars-exploration/problem
        public void MarsExploration()
        {
            string s = Console.ReadLine();
            int count = 0;
            var arr = s.ToCharArray();
            var sosArr = "SOS".ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != sosArr[i % 3])
                {
                    count++;
                }
            }
            Console.WriteLine(s.Length - count);
        }

        //https://www.hackerrank.com/challenges/hackerrank-in-a-string/problem
        public void CheckIfHacker()
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                var strQueue = new Queue<char>("hackerrank".ToCharArray());
                foreach (var c in s)
                {
                    if (strQueue.Count != 0 && c == strQueue.Peek())
                    {
                        strQueue.Dequeue();
                    }
                }
                if (strQueue.Count == 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }


        public void MaximumSubArray()
        { //3,4,5,6,7,8 -> 12,21
            string result = "";
            var arr = Console.ReadLine().Split(',');
            var k = 3;
            var tempSum = 0;
            for (var i = 0; i <= arr.Length - 1; i++)
            {
                if (i % k < k)
                {
                    tempSum += Convert.ToInt32(arr[i]);
                    if (i % k == k - 1)
                    {
                        result += tempSum.ToString() + ",";
                        tempSum = 0;
                    }
                }
            }

            Console.WriteLine(result);

        }

        //        Given a non-empty string s and a dictionary wordDict containing a list of non-empty words, determine if s can be segmented into a space-separated sequence of one or more dictionary words.You may assume the dictionary does not contain duplicate words.
        //For example, given
        //s = "leetcode",
        //dict = ["leet", "code"].
        //Return true because "leetcode" can be segmented as "leet code".
        public bool WordBreak(string input)
        {
            bool[] valids = new bool[input.Length];
            string[] arr = { "leet", "code" };
            if (input == null || input.Length == 0)
            {
                Console.WriteLine("False");
            }

            for (var i = 1; i <= input.Length; i++)
            {
                if (arr.Contains(input.Substring(0,i)) && WordBreak(input.Substring(0, i + 1))) //Revisit complex to understand
                {
                    Console.WriteLine("True");
                    return true;
                }
            }
            Console.WriteLine("False");
            return false;
        }


    }
}

