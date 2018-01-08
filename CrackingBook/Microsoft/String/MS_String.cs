using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Microsoft.String
{
    class MS_String
    {
        public double BinaryToDecimal(string number, int baseKey)
        {
            var dec = 0;
            for (int i = 0; i < number.Length; i++)
            {
                // we start with the least significant digit, and work our way to the left
                if (number[number.Length - i - 1] == '0') continue;
                dec += (int)Math.Pow(baseKey, i);
            }
            return dec;
        }
        //Given a very large binary number which cannot be stored in a variable, 
        //determine the remainder of the decimal equivalent of the binary number when divided by 3. 

        public string Reverse(string str)
        {
            var reversed = "";
            if (str.Length < 1)
            {
                return str;
            }
            var counter = str.Length - 1;
            while (counter >= 0)
            {
                reversed += str[counter];
                counter--;
            }
            return reversed;
        }

        /// <summary>
        /// One Way problem from cracking book 6th edition
        /// pale - ple - a insert - True
        /// pale - bale - p replace - True
        /// pales - pale - s remove - True
        /// pale - bake - false
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool OneWayEdit(string str1, string str2)
        {
            var diff = (str1.Length - str2.Length);
            if (diff < 1 || diff > -1)
            {
                foreach (var item in str1)
                {
                    if (str2.IndexOf(item) > -1)
                    {
                        str2 = str2.Remove(str2.IndexOf(item), 1);
                    }
                }
                return str2 != null && str2.Length <= 1;
            }
            return false;
        }

        //for any string
        public bool IsUniqueCharacters(string input)
        {
            var buffer = new StringBuilder();
            foreach (var item in input)
            {
                if (buffer.ToString().IndexOf(item) > -1)
                {
                    return false;
                }
                buffer.Append(item);
            }
            return true;
        }

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

        //http://www.geeksforgeeks.org/count-occurrences-of-a-word-in-string/
        public void CountStrings(string sentence, string word)
        {
            var words = sentence.Split(' ');
            var counter = 0;
            foreach (var item in words)
            {
                if (item == word) {
                    counter++;
                }
            }
            Console.WriteLine("No of Occurrences : " + counter);

        }

        //11001100110000 // every pass replace 0 with 1 if prev element is 1
        //how many pass to get to all 1's
        public string ZerosAndOnes(string input)
        {
            var arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '0') {
                    if (arr[i - 1] == '1') {
                        arr[i] = '1';
                    }
                }
            }
            return new string(arr);
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
