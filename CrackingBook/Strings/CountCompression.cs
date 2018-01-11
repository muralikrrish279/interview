using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Strings
{
    class CountCompression
    {
        public void Compress(string str)
        {
            if (str == null)
            {
                Console.WriteLine(str);
                return;
            }
            var builder = new StringBuilder();
            var map = new Dictionary<char, int>();

            foreach (var item in str)
            {
                if (!map.ContainsKey(item))
                {
                    map.Add(item, 1);
                }
                else
                {
                    map[item]++;
                }
            }

            foreach (var item in map)
            {
                builder.Append(item.Key);
                builder.Append(item.Value);
            }
            var output = (builder.ToString().Length >= str.Length) ? str : builder.ToString();
            Console.WriteLine(output);

        }

    }
}
