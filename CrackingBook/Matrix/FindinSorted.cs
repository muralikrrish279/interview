using System;
using System.Collections;
using System.Collections.Generic;

// https://www.geeksforgeeks.org/search-in-row-wise-and-column-wise-sorted-matrix/
public class FindinSorted
{

    // public static void Main(string[] args)
    // {
    //     // PrintMatrix(new int[][] {
    //     //     new int[]{10,20,30},
    //     //     new int[]{15,25,35},
    //     //     new int[]{16,26,36}});
    //     Find(new int[][] {
    //         new int[]{10,20,30},
    //         new int[]{15,25,35},
    //         new int[]{16,26,36}},26);
    // }

    public static void Find(int[][] mrx,int target)
    {
        int row = 0;
        int col = mrx.Length - 1;

        while (row <= mrx.Length && col > 0)
        {
            if(mrx[row][col] == target){
                Console.WriteLine(row + "," + col);
                break;
            }else if(target < mrx[row][col]){
                col--;
            }else{
                row++;
            }
        }
    }

    public static void PrintMatrix(int[][] mrx)
    {
        for (int i = 0; i < mrx.Length; i++)
        {
            if (i != 0)
            {
                Console.WriteLine();
            }
            for (int j = 0; j < mrx[0].Length; j++)
            {
                Console.Write(mrx[i][j]);
            }
        }
    }



}