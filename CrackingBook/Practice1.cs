using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook
{
    public class Practice1
    {
        public static void prodArray(int[] arr)
        {
            int temp = 1;
            int[] prod = new int[arr.Length];
            for (int j = 0; j < arr.Length; j++)
            {
                prod[j] = 1;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                prod[i] = temp;
                temp *= arr[i];
            }

            temp = 1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                prod[i] *= temp;
                temp *= arr[i];
            }

            foreach (var item in prod)
            {
                Console.Write(item);
            }

        }

        public static void DiagonalDiff(int[][] arr)
        {
            int firstDiag = 0;
            int secondDiag = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[0].Length; j++)
                {
                    if (i == j)
                    {
                        firstDiag += arr[i][j];
                    }

                    if (i + j == arr.Length - 1)
                    {
                        secondDiag += arr[i][j];
                    }
                }
            }

            Console.WriteLine(secondDiag - firstDiag);
        }

        public static void replacezeros(int[] arr)
        {
            int zeros = 0;
            int counter = 0;
            foreach (var item in arr)
            {
                if (item == 0)
                {
                    zeros++;
                }
            }

            while (zeros > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 0)
                    {
                        if (arr[i + 1] == 1)
                        {
                            arr[i] = 1;
                            zeros--;
                        }
                    }
                }

                counter++;
            }

            Console.WriteLine(counter);
        }

        //static void Main(string[] args)
        //{
        //    //prodArray(new int[] { 1, 2, 3, 4 });
        //    //DiagonalDiff(new int[][] {
        //    //         new int[]{10,20,30},
        //    //         new int[]{15,25,35},
        //    //         new int[]{16,26,36}});
        //    replacezeros(new int[] { 0, 1, 1, 1, 0, 0, 1, 0, 0, 0, 1 });
        //}
    }
}
