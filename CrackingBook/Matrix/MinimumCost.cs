using System;
using System.Collections;
using System.Collections.Generic;
public class MinCostPathMatrix
{
    //https://www.geeksforgeeks.org/dynamic-programming-set-6-min-cost-path/
    //public static void Main(string[] args)
    //{
    //    MinCostPath(new int[][] {
    //         new int[]{1,2,3},
    //         new int[]{4,8,2},
    //         new int[]{1,5,3},
    //         });
    //}



    public static void MinCostPath(int[][] mrx)
    {
        var dpTable = new int[mrx.Length][];
        for (int i = 0; i < mrx.Length; i++)
        {
            dpTable[i] = new int[mrx[0].Length];
        }

        for (int i = 0; i < mrx.Length; i++)
        {
            for (int j = 0; j < mrx[0].Length; j++)
            {
                if (i == 0 && j == 0)
                {
                    dpTable[0][0] = mrx[0][0];
                }
                else if (i == 0)
                {
                    dpTable[i][j] = mrx[i][j] + dpTable[i][j - 1];
                }
                else if (j == 0)
                {
                    dpTable[i][j] = mrx[i][j] + dpTable[i - 1][j];
                }
                else
                {
                    dpTable[i][j] = mrx[i][j] + Math.Min(dpTable[i -1][j - 1],Math.Min(dpTable[i - 1][j], dpTable[i][j - 1]));
                }

                if (i == mrx.Length - 1 && j == mrx[0].Length - 1)
                {
                    Console.WriteLine(dpTable[i][j]);
                }
            }
        }
    }




}