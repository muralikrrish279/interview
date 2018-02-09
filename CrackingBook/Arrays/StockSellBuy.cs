using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Arrays
{
    public class StockSellBuy
    {
        public class interval
        {
            public int buy;
            public int sell;
        }
        //static void Main(string[] args)
        //{
        //    FindDays(new int[] { 180, 100, 260, 310, 40, 535, 600 });
        //}

        static void FindDays(int[] arr)
        {

            int n = arr.Length;
            var i = 0;
            var solution = new List<interval>();
            while (i < n - 1)
            {
                while (i < n - 1 && arr[i + 1] <= arr[i])
                {
                    i++;
                }

                if (i == n - 1)
                {
                    break;
                }

                var inte = new interval();
                inte.buy = i;

                i++;

                while (i < n && arr[i - 1] <= arr[i])
                {
                    i++;
                }
                inte.sell = i - 1;
                solution.Add(inte);
            }

            foreach (var item in solution)
            {
                Console.WriteLine(item.buy + "___" + item.sell);
            }
        }
    }
}
