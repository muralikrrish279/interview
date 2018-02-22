using System; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using CrackingBook.Utils;

namespace CrackingBook
{
    //https://www.geeksforgeeks.org/word-ladder-length-of-shortest-chain-to-reach-a-target-word/
    public class WordLadder
    {
        public static void FindLadderLength(string source,string dest,HashSet<string> dict) {
            var que = new Utils.Queue<string>();
            que.EnQueue(source);

            while (!que.IsEmpty())
            {
                var temp = que.DeQueue();
                Console.WriteLine(temp);

                foreach (var item in dict)
                {
                    if (IsOneLetterAway(temp, item)) {                        
                        que.EnQueue(item);
                    }
                }

                if (dict.Contains(temp)) { //Like visited checking
                    dict.Remove(temp);
                }

            }
        }

        static bool IsOneLetterAway(string a, string b) {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i]) {
                    count++;
                }
            }

            return count == 1;
        }

        //static void Main(string[] args)
        //{
        //    var set = new HashSet<string> { "POON", "PLEE", "SAME", "POIE", "PLEA", "PLIE", "POIN" };
        //    FindLadderLength("TOON", "PLEA", set);
        //}
    }
}
