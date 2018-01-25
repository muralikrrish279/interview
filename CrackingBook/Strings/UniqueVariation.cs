using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook
{
    //Expedia phone round question
    public class UniqueVariation
    {
        public static void uniq(string str) {
            var stck = new Stack<char>();
            foreach (var item in str)
            {
                if (stck.Count > 0 && stck.Peek() == item)
                {
                    stck.Pop();
                }
                else {
                    stck.Push(item);
                }

            }
            var output = "";
            while (stck.Count > 0) {
                output += stck.Pop();
            }
            Console.WriteLine(output);
        }

        static void Main(string[] args)
        {
            uniq("aaabbcccddCaaa"); //output -> "acCa"
        }
    }
}
