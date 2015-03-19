/* Write a program that reads a text file containing a square matrix of numbers.
Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
The first line in the input file contains the size of matrix N.
Each of the next N lines contain N numbers separated by space.
The output should be a single number in a separate text file. */

using System;
using System.IO;
using System.Linq;

class MaximalAreaSum
{
    static void Main()
    {

        int[,] matrix;
        int matrixSize;
        int currentSum = 0;
        int maxSum = 0;

        using (StreamReader matrixFile = new StreamReader("matrix.txt"))
        {
            matrixSize = int.Parse(matrixFile.ReadLine());
            matrix = new int[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                int[] matrixRow = matrixFile.ReadLine().Split(' ')
                                                       .Select(x => int.Parse(x))
                                                       .ToArray();

                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = matrixRow[j];
                }
            }
        }


        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
        }

        Console.WriteLine(maxSum);
    }
}

