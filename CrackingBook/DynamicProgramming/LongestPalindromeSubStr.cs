using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook
{
    //Given a dictionary of words and a string of characters, find if the string of characters can be broken into individual valid words from the dictionary.
    //Example: 
    //Dictionary: arrays, dynamic, heaps, IDeserve, learn, learning, linked, list, platform, programming, stacks, trees
    //String    : IDeservelearningplatform
    //Output   : true 
    //Because the string can be broken into valid words: IDeserve learning platform
    public class LongestPalindromeSubString
    {

        public static string findPalindrome(string str) 
        {
            int n = str.Length;
            bool[][] dp = new bool[n][];
            for (int i = 0; i < n; i++)
            {
                dp[i] = new bool[n];
            }

            int maxLength = 1;
            int start = -1;
            for (int i = 0; i < n; i++)
            {
                dp[i][i] = true;
            }

            for (int i = 0; i < n - 1; i++)
            {
                if (str[i + 1] == str[i]) {
                    dp[i][i+1] = true;
                    start = i;
                    maxLength = 2;
                }
            }

            for (int k = 3; k < n; k++)
            {
                for (int i = 0; i < n-k + 1; i++)
                {
                    int j = i + k - 1;
                    if (dp[i + 1][j - 1] && str[i] == str[j]) {
                        dp[i][j] = true;
                        if (k > maxLength) {
                            maxLength= k;
                            start = i;
                        }
                    }
                }
            }

            if (start == -1) {
                return "No Palindrome Found";
            }
            return str.Substring(start, maxLength);

        }


        //static void Main(string[] args)
        //{
        //    //Console.WriteLine(findPalindrome("GEEKEG"));
        //    Console.WriteLine(findPalindrome("forgeekskeegfor"));
        //    //Console.WriteLine(findPalindrome("EE"));

        //}
    }
}
