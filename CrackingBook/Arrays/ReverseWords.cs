using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Arrays
{

    //reversing a words in a string
    public class ReverseWords
    {
        //static void Main(string[] args)
        //{
        //    revWords("The Sky is Blue Color");
        //}

        static void revWords(string input)
        {
            var arr = input.Split(' ');

            var start = 0;
            var end = arr.Length - 1;
            while (end >= (arr.Length - 1)/2)
            {
                var temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                end--;
                start++;
            }

            Console.WriteLine(String.Join(" ", arr));

        }


    }
}
