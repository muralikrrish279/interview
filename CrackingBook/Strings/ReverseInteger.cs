using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook
{
    public class ReverseInteger
    {
        public static void DoWork(int input)
        {
            var reversed = "";
            var temp = input;
            temp = Math.Abs(temp);
            while (temp != 0)
            {
                var ch = temp % 10;
                reversed += ch;
                temp = temp / 10;
            }
            if (input < 1) {
                reversed = "-" + reversed;
            }
            var output = 0;
            Int32.TryParse(reversed, out output);
            Console.Write(output);
        }

        //static void Main(string[] args)
        //{
        //    DoWork(123);
        //}
    }
}
