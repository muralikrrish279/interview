using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook
{
    public class CountZeros
    {

        //static void Main(string[] args)
        //{
        //    LongestSequence("01000001111011111111110000000111111");
        //}

        //Longest one/zero sequence in 2d array - MS Interview
        static void LongestSequence(string binaryString)
        {
            int max0Seq = 0;
            int max1Seq = 0;
            int tempmax1Seq = 0;
            int tempmax0Seq = 0;
            var arr = binaryString.Split(' ');
            for (var i = 0; i < arr.Length; i++) //0001101
            {
                if (arr[i] == "1")
                {
                    tempmax1Seq++;
                    tempmax0Seq = 0;
                    if (max1Seq < tempmax1Seq)
                    {
                        max1Seq = tempmax1Seq;
                    }
                }
                else
                {
                    tempmax0Seq++;
                    tempmax1Seq = 0;
                    if (max0Seq < tempmax0Seq)
                    {
                        max0Seq = tempmax0Seq;
                    }
                }

            }
            Console.WriteLine("Max no of 1 seq : " + max1Seq);
            Console.WriteLine("Max no of 0 seq : " + max0Seq);
        }
    }
}
