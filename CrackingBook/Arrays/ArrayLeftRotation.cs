using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Arrays
{
    public class ArrayLeftRotation
    {
        public static void rotateArray(int k,int[] array)
        {
            var items = array.Length;
            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                var newIndex = (i + k) % items;
                newArray[i] = array[newIndex];
            }
            // ******************** Strings and Arrays *******************************
            Console.WriteLine(String.Join(" ", newArray));
        }

        //static void Main(string[] args)
        //{
        //    rotateArray(3,new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
        //}

    }
}
