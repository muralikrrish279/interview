using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Strings
{
    public class Minseries
    {
        //min(int, min(int, min(int, int)))
        public void MinSeries()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 2 || n >= 50)
            {
                Console.WriteLine("Invalid Input");
            }
            var simpleString = ",int";
            for (int i = 0; i < n - 1; i++)
            {
                simpleString = simpleString.Replace(",int", ",min(int,int)");
            }
            Console.WriteLine(simpleString.Substring(1));
        }
    }
}
