using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.StringsandArrays
{
    class RotateMatrix
    {

        private static readonly Random RandomIntNumbers = new Random();

        public static int RandomInt(int n)
        {
            return RandomIntNumbers.Next(n);
        }

        public static int RandomIntInRange(int min, int max)
        {
            return RandomInt(max + 1 - min) + min;
        }
        private void Rotate(int[][] matrix, int n)
        {
            for (var layer = 0; layer < n / 2; ++layer)
            {
                var first = layer;
                var last = n - 1 - layer;

                for (var i = first; i < last; ++i)
                {
                    var offset = i - first;
                    var top = matrix[first][i]; // save top

                    // left -> top
                    matrix[first][i] = matrix[last - offset][first];

                    // bottom -> left
                    matrix[last - offset][first] = matrix[last][last - offset];

                    // right -> bottom
                    matrix[last][last - offset] = matrix[i][last];

                    // top -> right
                    matrix[i][last] = top; // right <- saved top
                }
            }
        }


        public static int[][] RandomMatrix(int m, int n, int min, int max)
        {
            int[][] matrix = new int[m][];
            for (int i = 0; i < m; i++)
            {
                matrix[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    matrix[i][j] = RandomIntInRange(min, max);
                }
            }
            return matrix;
        }


        public static void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] < 10 && matrix[i][j] > -10)
                    {
                        Console.Write(" ");
                    }
                    if (matrix[i][j] < 100 && matrix[i][j] > -100)
                    {
                        Console.Write(" ");
                    }
                    if (matrix[i][j] >= 0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(" " + matrix[i][j]);
                }
                Console.WriteLine();
            }
        }

        public void Run()
        {
            const int size = 5;

            var matrix = RandomMatrix(size, size, 0, 9);

            PrintMatrix(matrix);

            Rotate(matrix, size);
            Console.WriteLine();
            PrintMatrix(matrix);
        }
    }
}
