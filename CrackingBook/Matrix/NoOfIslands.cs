using System;
using System.Collections;
using System.Collections.Generic;
public class NoOfIslands
{
	//https://www.geeksforgeeks.org/find-number-of-islands/
  //   public static void Main(string[] args)
  //   {
		//Islands(new int[][] {
		//	new int[]{1, 1, 0, 0, 0},
		//	new int[]{0, 1, 0, 0, 1},
		//	new int[]{1, 0, 0, 1, 1},
		//	new int[] {0, 0, 0, 0, 0},
		//	new int[] {1, 0, 1, 0, 1}
		//}
     //        );
     //}

    public static int[] r = new int[] { -1, 0, 1, 1, 1, 0, -1, -1 };
    public static int[] c = new int[] { -1, -1, -1, 0, 1, 1, 1, 0 };
	public static void DFS(int[][] mrx, int row, int col,bool[][] dpTable)
    {

		dpTable[row][col] = true;
        for (int i = 0; i < 8; i++)
        {
            var newRow = row + r[i];
            var newCol = col + c[i];
            if (newRow >= 0 && newCol >= 0 && newRow < mrx.Length && newCol < mrx[0].Length 
			    && !dpTable[newRow][newCol] && mrx[newRow][newCol] == 1)
            {
				DFS(mrx, newRow, newCol, dpTable);
            }

        }
    }


	public static void Islands(int[][] mrx)
    {
		var count = 0;
		var dpTable = new bool[mrx.Length][];
        for (int i = 0; i < mrx.Length; i++)
        {
			dpTable[i] = new bool[mrx[0].Length];
        }

		for (int i = 0; i < mrx.Length; i++)
        {
            for (int j = 0; j < mrx[0].Length; j++)
            {
				if (mrx[i][j] == 1 && !dpTable[i][j])
                {
					count++;
					DFS(mrx, i, j, dpTable);

                }
            }
        }
		Console.WriteLine(count);
    }




}