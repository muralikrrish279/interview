using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Arrays
{

    //https://www.geeksforgeeks.org/a-product-array-puzzle/
    public class ProductArray
    {
        //static void Main(string[] args)
        //{
        //    var intArr = new int[] { 10,3,5,6,2 };
        //    PrintProductArray(intArr);
        //}

        static void PrintProductArray(int[] input)
        {
            int temp = 1;
            //init prod array with all 1's
            int[] prod = new int[input.Length];
            for (int j = 0; j < prod.Length; j++)
            {
                prod[j] = 1;
            }

            //multiply all elements right side
            for (int i = 0; i < input.Length; i++)
            {
                prod[i] = temp;
                temp *= input[i];
            }

            temp = 1;
            //multiply all left side
            for (int i = input.Length - 1; i >= 0; i--)
            {
                prod[i] *= temp;
                temp *= input[i];
            }

            foreach (var item in prod)
            {
                Console.Write(item + ",");
            }

        }


    }
}
