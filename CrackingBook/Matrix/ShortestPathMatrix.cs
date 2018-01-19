using System;
using System.Collections;
using System.Collections.Generic;
public class ShortestPathMatrix
{
    //https://www.geeksforgeeks.org/shortest-path-in-a-binary-maze/
    // public static void Main(string[] args)
    // {
    //     ShortPath(new int[][] {
    //         new int[]{1,1,0,1},
    //         new int[]{1,0,1,1},
    //         new int[]{1,1,1,1},
    //         }, new Point(0, 0), new Point(0, 3));
    // }

    public class Point
    {
        public int row;
        public int col;

        public int dist;
        public Point(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }

    public static List<Point> getAdjacents(Point input, int rowUB, int colUB)
    {
        int row = input.row;
        int col = input.col;
        List<Point> points = new List<Point>();
        if (row < rowUB)
            points.Add(new Point(row + 1, col));
        if (row > 0)
            points.Add(new Point(row - 1, col));
        if (col < colUB)
            points.Add(new Point(row, col + 1));
        if (col > 0)
            points.Add(new Point(row, col - 1));

        return points;

    }


    public static void ShortPath(int[][] mrx, Point source, Point dest)
    {
        var visited = new bool[mrx.Length][];
        for (int i = 0; i < mrx.Length; i++)
        {
            visited[i] = new bool[mrx[0].Length];
        }
        var que = new Queue<Point>();
        visited[source.row][source.col] = true;
        que.Enqueue(source);
        while (que.Count != 0)
        {
            var temp = que.Dequeue();
            if (temp.row == dest.row && temp.col == dest.col)
            {
                Console.WriteLine(temp.dist);
                return;
            }

            var adjs = getAdjacents(temp, mrx.Length - 1, mrx[0].Length - 1);

            foreach (var item in adjs)
            {
                if (mrx[item.row][item.col] == 1 && !visited[item.row][item.col])
                {
                    item.dist = temp.dist + 1;
                    visited[item.row][item.col] = true;
                    que.Enqueue(item);
                }
            }
        }
        Console.WriteLine("No Path Found");
    }




}