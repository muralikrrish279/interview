using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.HackerRank.WarmUp
{
    class TimeConversion
    {
        public void build()
        {
            string time = Console.ReadLine();
            string[] arr = time.Split(':');
            if (time.IndexOf("PM") > -1)
            {
                arr[0] = (Convert.ToInt16(arr[0]) + 12).ToString();
            }
            else if (time.IndexOf("AM") > -1 && arr[0] == "12")
            {
                arr[0] = "00";
            }

            Console.WriteLine(string.Join(":", arr));
        }
    }
}

