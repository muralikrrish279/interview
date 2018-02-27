using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Matrix
{
    //    Given a square matrix of size, calculate the absolute difference between the sums of its diagonals.

    //Input Format

    //The first line contains a single integer, . The next  lines denote the matrix's rows, with each line containing space-separated integers describing the columns.

    //Output Format

    //Print the absolute difference between the two sums of the matrix's diagonals as a single integer.

    //Sample Input

    //3
    //11 2 4
    //4 5 6
    //10 8 -12
    //Sample Output

    //15
    //Explanation

    //The primary diagonal is: 
    //11
    //      5
    //            -12

    //Sum across the primary diagonal: 11 + 5 - 12 = 4

    //The secondary diagonal is:
    //            4
    //      5
    //10
    //Sum across the secondary diagonal: 4 + 5 + 10 = 19 
    //Difference: |4 - 19| = 15
    class DiagonalDifference
    {
        void DiagonalDiff()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = System.Array.ConvertAll(a_temp, Int32.Parse);
            }
            int firstDiagonal = 0;
            int secondDiagonal = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; i < n; j++)
                {
                    if (i == j) {
                        firstDiagonal += a[i][j];
                    }
                    if (i + j == n - 1) {
                        secondDiagonal += a[i][j];
                    }
                }
            }
   

            Console.WriteLine(Math.Abs(firstDiagonal - secondDiagonal));
        }
    }
}
