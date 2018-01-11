using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Strings
{
    class Anagram
    {

        public bool IsAnagram(string s1, string s2)
        {
            foreach (var c in s2)
            {
                int index = s1.IndexOf(c);
                if (index > -1) s1 = s1.Remove(index, 1);
            }
            return string.IsNullOrEmpty(s1);
        }
    }
}
