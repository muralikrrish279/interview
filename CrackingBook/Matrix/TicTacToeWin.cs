using System;
using System.Collections;
using System.Collections.Generic;
public class TicTacToeWin
{
    
    //public static void Main(string[] args)
    //{
    //    var output = CheckWin(new int[][] {
    //        new int[]{1,0,0,1},
    //        new int[]{0,1,1,0},
    //        new int[]{1,1,1,0},
    //        new int[]{1,1,0,0}
    //        });
    //    Console.WriteLine(output);
    //    Console.ReadLine();
    //}


    public static bool CheckWin(int[][] m){

        //check rows m[i][0]
        for (int i = 0; i < m.Length; i++)
        {
            var first = m[i][0];
            for (int j = 1; j < m[0].Length; j++)
            {
                if (m[i][j] != first){
                    break;
                }else if(j == m[0].Length - 1){
                    return true;
                }
            }
        }

        //check columns m[0][i]
		for (int i = 0; i < m.Length; i++)
		{
            var first = m[0][i];
			for (int j = 1; j < m[0].Length; j++)
			{
				if (m[i][j] != first)
				{
					break;
				}
				else if (j == m[0].Length - 1)
				{
					return true;
				}
			}
		}

        //check first diagonal
		var search = m[0][0];
		for (int j = 1; j < m[0].Length; j++)
		{
			if (m[j][j] != search)
			{
				break;
			}
			else if (j == m[0].Length - 1)
			{
				return true;
			}
		}

        //Check second diagonal
        var size = m[0].Length;
		var search1 = m[0][size -1];
		for (int j = 1; j < m[0].Length; j++)
		{
			if (m[j][size - j - 1] != search1)
			{
				break;
			}
			else if (j == m[0].Length - 1)
			{
				return true;
			}
		}

        return false;
    }





}