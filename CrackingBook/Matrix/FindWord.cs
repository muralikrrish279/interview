using System;
using System.Collections;
using System.Collections.Generic;
public class FindWord
{
    //https://www.geeksforgeeks.org/shortest-path-in-a-binary-maze/
    // public static void Main(string[] args)
    // {
    //     findword(new char[][] {
    //         new char[]{'o','m','u','x'},
    //         new char[]{'c','a','r','p'},
    //         new char[]{'i','l','v','k'}}, "pram"
    //         );
    // }

    public class Point
    {
        public int row;
        public int col;
        public char data;
        public Point(int row, int col, char data)
        {
            this.row = row;
            this.col = col;
            this.data = data;
        }
    }

    public static int[] r = new int[] { -1, 0, 1, 1, 1, 0, -1, -1 };
    public static int[] c = new int[] { -1, -1, -1, 0, 1, 1, 1, 0 };
    public static List<Point> getAdjs(char[][] mrx, int row, int col)
    {
        var lst = new List<Point>();
        for (int i = 0; i < 8; i++)
        {
            var newRow = row + r[i];
            var newCol = col + c[i];
            if (newRow >= 0 && newCol >= 0 && newRow < mrx.Length && newCol < mrx[0].Length)
            {
                lst.Add(new Point(newRow, newCol, mrx[newRow][newCol]));
            }

        }
        return lst;
    }


    public static void findword(char[][] mrx, string target)
    {
        for (int i = 0; i < mrx.Length; i++)
        {
            for (int j = 0; j < mrx[0].Length; j++)
            {
                if (findhelper(mrx, i, j, target))
                {
                    Console.WriteLine("Word Found");
                    return;
                }
            }
        }
        Console.WriteLine("Word not Found");
    }

    public static bool findhelper(char[][] mrx, int row, int col, string target)
    {
        if (mrx[row][col] != target[0])
        {
            return false;
        }
        var queue = new Queue<Point>();
        queue.Enqueue(new Point(row, col, mrx[row][col]));

        var nextLetterIndex = 1;
        while (queue.Count > 0)
        {
            var temp = queue.Dequeue();
            var adjs = getAdjs(mrx, temp.row, temp.col);
            foreach (var item in adjs)
            {
                if (item.data == target[nextLetterIndex])
                {
                    queue.Enqueue(item);
                    nextLetterIndex++;
                }
                if (nextLetterIndex == target.Length - 1)
                {
                    return true;
                }
            }

        }
        return false;
    }




}