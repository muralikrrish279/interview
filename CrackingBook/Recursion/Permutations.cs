using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Recursion
{
    class Permutations
    {

        public List<string> BuildPermutations(string input) //abc
        {
            List<string> perms = new List<string>();

            if (input.Length == 0) {
                perms.Add("");
                return perms;
            }
            string first = input.Substring(0,1); //a
            string remainder = input.Substring(1); //bc
            var words = BuildPermutations(remainder);

            foreach (var item in words)
            {
                for (int i = 0; i <= item.Length; i++)
                {
                    perms.Add(item.Substring(0, i) + first + item.Substring(i));
                }
            }

            return perms;

        }
    }
}
 