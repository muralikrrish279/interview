using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.hackerrank.com/challenges/reduced-string
namespace CrackingBook.HackerRank.String
{
    public class ReducedString
    {
        public void print()
        {
            string str = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            char charInLoop = Convert.ToChar("");
            foreach (var item in str)
            {
                if (charInLoop != Convert.ToChar(item)) {
                    result.Append(item);
                }
                charInLoop = item;
            }

        }

    }
}
