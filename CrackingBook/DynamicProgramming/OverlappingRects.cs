using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    //https://www.geeksforgeeks.org/total-area-two-overlapping-rectangles/
    public class OverlappingRects
    {

        public static int TotalArea(Point L1, Point R1, Point L2, Point R2)
        {
            int width = Math.Min(R2.x, R1.x) - Math.Max(L2.x, L1.x);
            int length = Math.Min(R2.y, R1.y) - Math.Max(L2.y, L1.y);
            if (width < 0 || length < 0)
            {
                return -1;
            }
            return width * length;
        }


        //static void Main(string[] args)
        //{
        //    Console.WriteLine(TotalArea(new Point(2, 2), new Point(5, 7), new Point(3, 4), new Point(6, 9)));
        //}
    }
}
