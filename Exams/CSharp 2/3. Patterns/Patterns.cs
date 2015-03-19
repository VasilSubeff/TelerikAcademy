using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Patterns
{
    static void Main(string[] args)
    {

        var matrix = ReadMatrix();
        int sumOfMainDiag = CalcSumOfMainDiag(matrix);
        int maxSum = 0;

        int startRow = 0;
        int startCol = 0;

       


        bool patternExists = false;

        while ((startRow + 2) <= matrix.GetLength(0) - 1 && (startCol + 4) <= matrix.GetLength(1) - 1)
        {
            int currentCol = startCol;
            int currentRow = startRow;

            int a = matrix[currentRow, currentCol];
            int b = matrix[currentRow, currentCol + 1];
            int c = matrix[currentRow, currentCol + 2];

            int d = matrix[currentRow + 1, currentCol + 2];
            int e = matrix[currentRow + 2, currentCol + 2];

            int f = matrix[currentRow + 2, currentCol + 3];
            int g = matrix[currentRow + 2, currentCol + 4];

            int sum = 0;

            if ((a == b - 1) && (b == c - 1) && (c == d - 1) && (d == e - 1) && (e == f - 1) && (f == g - 1))
            {
                sum = a + b + c + d + e + f + g;
                patternExists = true;
            }

            if (maxSum < sum)
            {
                maxSum = sum;
            }

            if (currentCol + 4 < matrix.GetLength(0) - 1)
            {
                startCol++;
            }
            else
            {
                startCol = 0;

                if (currentRow + 2 < matrix.GetLength(1) - 1)
                {
                    startRow++;
                }
                else
                {
                    startCol++;
                    startRow++;
                }
            }
        }

        if (patternExists)
        {
            Console.WriteLine("YES {0}", maxSum);
        }
        else
        {
            Console.WriteLine("NO {0}", sumOfMainDiag);
        }
        
    }

    private static int CalcSumOfMainDiag(int[,] matrix)
    {
        int startRow = 0;
        int startCol = 0;
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[startCol, startRow];
            startRow++;
            startCol++;
        }
        return sum;
    }

    private static int[,] ReadMatrix()
    {
        int matrixSize = int.Parse(Console.ReadLine());
        int[,] matrix = new int[matrixSize, matrixSize];

        for (int i = 0; i < matrixSize; i++)
        {
            string row = Console.ReadLine();
            string[] matrixRow = row.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < matrixRow.Length; j++)
            {
                matrix[i, j] = Convert.ToInt32(matrixRow[j]);
            }

        }
        return matrix;
    }
}

