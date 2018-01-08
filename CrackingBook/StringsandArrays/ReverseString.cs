using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.StringsandArrays
{
    class ReverseString
    {
        public void reverse(string str)
        {
            if (str == null)
            {
                Console.WriteLine(str);
                return;
            }
            string reversed = "";
            int counter = str.Length - 1;

            while (counter >= 0)
            {
                reversed += str[counter];
                counter--;
            }

            Console.WriteLine(reversed);

        }

    }
}
