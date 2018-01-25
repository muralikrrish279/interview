using System;
using System.Collections;
using System.Collections.Generic;
public class UniqueRows
{
    //https://www.geeksforgeeks.org/print-unique-rows/
    //public static void Main(string[] args)
    //{
    //    UniqueRowsFind(new int[][] {
    //        new int[]{1,0,0,0},
    //        new int[]{0,0,0,0},
    //        new int[]{0,1,0,0},
    //        new int[]{0,0,0,0}
    //        });
    //}


    public static void UniqueRowsFind(int[][] m){
        var dict = new Dictionary<string,int>();
        for (int i = 0; i < m.Length; i++)
        {
            var strinContent = "";
            for (int j = 0; j < m[0].Length; j++)
            {
                strinContent += m[i][j].ToString();
            }

            if(!dict.ContainsKey(strinContent)){
                dict.Add(strinContent,1);
            }

        }

        foreach (var item in dict)
        {
            var arr = item.Key.Split(' ');
            foreach (var num in arr)
            {
                Console.Write(num);
                Console.WriteLine();
            }
        }
    }





}