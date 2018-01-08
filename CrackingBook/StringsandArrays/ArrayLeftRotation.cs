using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.StringsandArrays
{
    public class ArrayLeftRotation
    {
        public void rotateArray(int n,int k,int[] array)
        {
            int[] newArray = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                var newIndex = (i + k) % n;
                newArray[i] = array[newIndex];
            }
            // ******************** Strings and Arrays *******************************
            Console.WriteLine(String.Join(" ", newArray));
        }

    }
}
