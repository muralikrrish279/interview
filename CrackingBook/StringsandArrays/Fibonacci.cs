using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook
{
    class Fibonacci
    {

        public void BuildSeries(int input)
        {
            int first = 1;
            int second = 1;
            for (int i = 3; i < input; i++)
            {
                if (second == input) return;
                int c = first + second;
                first = second;
                second = c;
                Console.WriteLine(second);
            }
        }
    }
}
