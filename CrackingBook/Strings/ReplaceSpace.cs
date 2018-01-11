using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Strings
{
    class ReplaceSpace
    {

        public string ReplaceSpaceInString(string s1)
        {
            int spaceCount = 0;
            char[] chars = s1.ToCharArray();
            for (int i = 0; i < s1.Length - 1; i++)
            {
                if (chars[i] == Convert.ToChar(" "))
                {
                    spaceCount++;
                }
            }

            int newlength = chars.Length + (spaceCount * 2);
            string[] str = new string[newlength];
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                if (chars[i] == Convert.ToChar(" "))
                {
                    str[newlength - 3] = "2";
                    str[newlength - 2] = "0";
                    str[newlength - 1] = "%";
                    newlength -= 3;
                }
                else
                {
                    str[newlength - 1] = Convert.ToString(chars[i]);
                    newlength -= 1;
                }
            }

            return String.Join("", str);
        }
    }
}
