using System;
using System.Collections;
using System.Collections.Generic;
public class BooleanMatrix
{
    //https://www.geeksforgeeks.org/a-boolean-matrix-question/
    // public static void Main(string[] args)
    // {
    //     BuildMatrix(new int[][] {
    //         new int[]{1,0,0,0},
    //         new int[]{0,0,0,0},
    //         new int[]{0,0,0,0},
    //         });
    // }



    public static void BuildMatrix(int[][] mrx)
    {
        bool rowFlag = false;
        bool colFlag = false;

        //traverse all rows to check 1's and update row0 to 1
        for (int i = 0; i < mrx.Length; i++)
        {
            for (int j = 0; j < mrx[0].Length; j++)
            {
                if (mrx[i][j] == 1)
                {
                    if (i == 0)
                        rowFlag = true;
                    if (j == 0)
                        colFlag = true;
                    mrx[0][j] = 1;
                    mrx[i][0] = 1;
                }
            }
        }
        //traverse all cols to check 1's and update col0 to 1
        for (int i = 1; i < mrx.Length; i++)
        {
            for (int j = 1; j < mrx[0].Length; j++)
            {
                if (mrx[0][j] == 1 || mrx[i][0] == 1)
                {
                    mrx[i][j] = 1;
                }
            }
        }
        //traverse all other cells if row0 is one then update cells to 1
        if (rowFlag)
        {
            for (int i = 1; i < mrx.Length; i++)
            {
                for (int j = 1; j < mrx[0].Length; j++)
                {
                    mrx[0][j] = 1;
                }
            }
        }
        //traverse all other cells if col0 is one then update cells to 1
        if (colFlag)
        {
            for (int i = 1; i < mrx.Length; i++)
            {
                for (int j = 1; j < mrx[0].Length; j++)
                {
                    mrx[i][0] = 1;
                }
            }
        }
        PrintMatrix(mrx);
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