using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    internal class Matrix
    {
        public static void InitMatrix()
        {
            int[,] matrix = new int[5, 5];

            matrix[0, 0] = 15;
            matrix[1, 1] = 15;
            matrix[2, 4] = 45;

            char[,] matrixChar =
            {
                {'A', 'B', 'C' },
                {'D', 'E', 'F' },
                {'G', 'H', 'I' },
            };
        }

        public static int[,] FillRandomMatrix(int row, int col)
        {
            int[,] matrix = new int[row, col];

            Random random = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(21);
                }
            }

            return matrix;
        }

        public static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static int[,] MatrixDiagonal(int row, int col)
        {
            int[,] matrix = new int[row, col];
            int counter = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        matrix[i, j] = counter++;
                    } else if(i > j)
                    {
                        matrix[i, j] = 20;
                    } else if(j > i)
                    {
                        matrix[i, j] = 10;
                    }
                }
            }

            return matrix;
        }




    }


}
