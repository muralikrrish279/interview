using System;
using System.Collections;
using System.Collections.Generic;
public class PondSizes
{
	//Crcking Book 16.19
	//public static void Main(string[] args)
	//{
	//	PondSizesFind(new int[][] {
	//		new int[]{0,2,1,0},
	//		new int[]{0,1,0,1},
	//		new int[]{1,1,0,1},
	//		new int[]{0,1,0,1}
	//	}
	//		 );
	//}

	public static int[] r = new int[] { -1, 0, 1, 1, 1, 0, -1, -1 };
	public static int[] c = new int[] { -1, -1, -1, 0, 1, 1, 1, 0 };
	private static int DFS1(int[][] mrx, int row, int col, bool[][] dpTable)
	{
		int result = 0;
		dpTable[row][col] = true;
		for (int i = 0; i < 8; i++)
		{
			var newRow = row + r[i];
			var newCol = col + c[i];
			if (newRow >= 0 && newCol >= 0 && newRow < mrx.Length && newCol < mrx[0].Length
				&& !dpTable[newRow][newCol] && mrx[newRow][newCol] == 0)
			{
				result = 1 + DFS1(mrx, newRow, newCol, dpTable);
			}

		}
		return result;
	}


	public static void PondSizesFind(int[][] mrx)
	{
		var dpTable = new bool[mrx.Length][];
		for (int i = 0; i < mrx.Length; i++)
		{
			dpTable[i] = new bool[mrx[0].Length];
		}

		for (int i = 0; i < mrx.Length; i++)
		{
			for (int j = 0; j < mrx[0].Length; j++)
			{
				if (mrx[i][j] == 0 && !dpTable[i][j])
				{
					var result = 1 + DFS1(mrx, i, j, dpTable);
					Console.WriteLine(result);
				}
			}
		}
	}




}