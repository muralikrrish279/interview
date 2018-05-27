using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook
{
	//Cracking book 16.20
	class PhoneDialPad
	{
		private static char[][] dialPadChars = new char[][]{
			new char[]{' '},
			new char[]{' '},
			new char[]{'a','b','c'},
			new char[]{'d','e','f'},
			new char[]{'g','h','i'},
			new char[]{'j','k','l'},
			new char[]{'m','n','o'},
			new char[]{'p','q','r','s'},
			new char[]{'t','u','v'},
			new char[]{'x','y','z'}
		};

		public static string ValidWords(int number, HashSet<string> set)
		{
			var values = new List<string>();
			var output = "";
			ValidWordsHelp(number, set, "",0,values);
			values.ForEach(x => output += x);
			return output;
		}

		public static void ValidWordsHelp(int number, HashSet<string> set,string prefix, int index,List<string> values)
		{
			//Console.WriteLine(prefix);
			if(number <0){
				values.Add("");
				return;
			}

			if(index == number.ToString().Length){
				if(set.Contains(prefix)){
					values.Add(prefix);
				}
				return;
			}

			int digit = System.Array.ConvertAll(number.ToString().ToArray(), x => (int)x - 48)[index];

            foreach (var item in dialPadChars[digit])
			{
				ValidWordsHelp(number, set, prefix + item, index + 1, values);
			}
			return;
		}


		//static void Main(string[] args)
   //     {
			//var set = new HashSet<string>() { "tree", "used", "moon" };
			////Console.WriteLine(ValidWords(8733,set));
			////Console.WriteLine(ValidWords(6666, set));
        //}

      
    }
}
                              