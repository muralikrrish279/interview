using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook
{
    class UniquesCharacters
    {
        private string input = "";
        public UniquesCharacters(string inputStr) {
            this.input = inputStr;
        }

        //Only for ASCII
        public bool IsUniqueCharactersForAscii() {
            Boolean[] chars = new Boolean[256];
            for (int i = 0; i < this.input.Length -1; i++)
            {
                Char val = input.ToCharArray()[i];
                if(chars[val])
                    return false;
                chars[val] = true;
            }
            return true;
        }

    }
}
