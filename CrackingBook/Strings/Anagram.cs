using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Strings
{
    class Anagram
    {

        public static bool IsAnagram(string s1, string s2)
        {
			if (s1 == null || s2 == null)
            {
                return false;
            }
			if(s1.Length != s2.Length){
				return false;
			}

			var temp = new int[256];
            for (int i = 0; i < s1.Length; i++)
			{
				temp[s1[i]]++;
				temp[s2[i]]--;
			}

			foreach (var item in temp)
			{
				if(item > 0){
					return false;
				}
			}
			return true;
        }

		//static void Main(){
		//	Console.WriteLine(IsAnagram("LEVEL", "LEVEL"));
		//}
    }
}
