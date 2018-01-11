using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Microsoft.String
{
    class MS_String
    {      

        public bool IsPalindromePermutation(string input) //evell : level -> level is palindrome
        {
            int countodd = 0;
            var dic = new Dictionary<char, int>();
            foreach (var item in input.Trim())
            {
                if (dic.ContainsKey(item))
                    dic[item]++;
                else
                    dic.Add(item, 1);

                if (dic[item] % 2 == 1)
                    countodd++;
                else
                    countodd--;
            }
            return countodd <= 1;
        }

        public HashSet<string>[] Anagrams(string[] input)
        {
            var dict = new Dictionary<string, HashSet<string>>();
            foreach (var item in input)
            {
                var chars = item.ToCharArray();
                Array.Sort(chars);
                var sortedString = new string(chars);
                if (dict.ContainsKey(sortedString))
                {
                    HashSet<string> set = dict[sortedString];
                    if (!set.Contains(item))
                    {
                        set.Add(item);
                    }
                }
                else
                {
                    dict.Add(sortedString, new HashSet<string>() { item });
                }
            }
            return dict.Values.ToArray();
        }



        //11001100110000 // every pass replace 0 with 1 if next element is 1
        //how many pass to get to all 1's
        public int ZerosAndOnesWithNext(string input)
        {
            var arr = input.ToCharArray();
            int ones = 0;
            int zeros = 0;
            int counter = 0;
            foreach (var item in arr)
            {
                if (item == '1')
                {
                    ones++;
                }
                else
                {
                    zeros++;
                }
            }
            while (zeros > 0) {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == '0')
                    {
                        if (arr[i + 1] == '1')
                        {
                            arr[i] = '1';
                            zeros--;
                        }
                    }
                }
                counter++;
            }
            
            return counter;
        }
    }
}
