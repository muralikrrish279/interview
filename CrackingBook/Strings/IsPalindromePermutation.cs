using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Strings
{
    public class IsPalindromePermutation
    {
        public static bool Check(string input) //evell : level -> level is palindrome
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

        static void Main(string[] args)
        {
            Console.WriteLine(Check("LEVEL"));
        }
    }
}
