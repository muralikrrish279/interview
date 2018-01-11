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
            var builder = new StringBuilder();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--) 
            {

                //abcd;              
                builder.Insert(i, str[j]);
                builder.Insert(builder.Length - i, str[i]);

            }
            if(str.Length % 2 != 0)
            {
                builder.Insert(str.Length / 2, str[str.Length / 2]);
            }

            Console.WriteLine(builder.ToString());

        }

    }
}
