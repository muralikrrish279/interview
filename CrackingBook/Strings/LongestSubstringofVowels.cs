using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook
{
    class LongestSubstringofVowels
    {

        //https://www.geeksforgeeks.org/longest-substring-vowels/
        public static int findVowels(string input)
        {
            int current = 0;
            int maxLength = 0;
            foreach (var item in input)
            {
                if (isVowel(item))
                {
                    current++;
                }
                else {
                    current = 0;
                }
                if (current > maxLength) {
                    maxLength = current;                    
                }
            }
            return maxLength;
        }

        private static bool isVowel(char c) {
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(findVowels("bcdsit"));
        //}
    }
}
