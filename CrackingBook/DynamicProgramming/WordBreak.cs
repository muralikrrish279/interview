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
    public class WordBreak
    {

        public static bool DoWorkDynamicProgramming(HashSet<string> dict, string str)
        {
            bool[] dpTable = new bool[str.Length];
            for (int i = 1; i <= str.Length; i++)
            {
                if (dpTable[i] == false && dict.Contains(str.Substring(0, i)))
                {
                    dpTable[i] = true;
                }

                if (dpTable[i])
                {
                    if (i == str.Length) return true;

                    for (int j = i + 1; j <= str.Length; j++)
                    {
                        if (dpTable[j] == false && dict.Contains(str.Substring(i, j - i))) //Not working 
                        {
                            dpTable[j] = true;
                        }

                        if (dpTable[j] && j == str.Length)
                        {
                            return true;
                        }
                    }
                }

            }
            return false;
        }
        public static bool DoWorkRecursively(HashSet<string> dict, string str)
        {
            if (str.Length == 0)
            {
                return true;
            }
            for (int i = 1; i <= str.Length; i++)
            {
                var sub = str.Substring(0, i);
                if (dict.Contains(sub) && DoWorkRecursively(dict, str.Substring(i, str.Length - i)))
                {
                    return true;
                }
            }
            return false;
        }


        //static void Main(string[] args)
        //{
        //    //Console.WriteLine(DoWorkRecursively(new HashSet<string> { "arrays", "dynamic", "heaps", "IDeserve", "learn", "learning", "linked", "list", "platform", "programming", "stacks", "trees" },
        //    //    "IDeservelearningplatform"));

        //    //Console.WriteLine(DoWorkDynamicProgramming(new HashSet<string> { "arrays", "dynamic", "heaps", "IDeserve", "learn", "learning", "linked", "list", "platform", "programming", "stacks", "trees" },
        //    //    "IDeservelearningplatform"));
        //}
    }
}
