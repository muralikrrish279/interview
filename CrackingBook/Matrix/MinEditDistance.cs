using System;
using System.Collections;
using System.Collections.Generic;
public class MinEditDistance
{
    //https://www.geeksforgeeks.org/dynamic-programming-set-5-edit-distance/
    //public static void Main(string[] args)
    //{
    //    EditDistance("murali", "mu2fi"); //answer must be 3 : r -> 2,a -> f & insert l
    //}



    public static void EditDistance(string str1, string str2)
    {
        var dpTable = new int[str1.Length + 1][];
        for (int i = 0; i < dpTable.Length; i++)
        {
            dpTable[i] = new int[str2.Length + 1];
        }

        for (int i = 0; i < dpTable.Length; i++)
        {
            for (int j = 0; j < dpTable[0].Length; j++)
            {
                if (i == 0)
                {
                    dpTable[i][j] = j;
                }
                else if (j == 0)
                {
                    dpTable[i][j] = i;
                }
                else if (str1[i - 1] == str2[j - 1])
                {
                    dpTable[i][j] = dpTable[i - 1][j - 1];
                }
                else
                {
                    dpTable[i][j] = 1 + Math.Min(dpTable[i - 1][j - 1], Math.Min(dpTable[i - 1][j], dpTable[i][j - 1]));
                }
            }
        }

        Console.WriteLine(dpTable[dpTable.Length - 1][dpTable[0].Length - 1]);
    }




}