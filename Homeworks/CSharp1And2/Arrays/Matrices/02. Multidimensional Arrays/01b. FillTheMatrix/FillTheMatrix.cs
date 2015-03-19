//Write a program that fills and prints a matrix of size (n, n) as shown below:

//1	8	9	16
//2	7	10	15
//3	6	11	14
//4	5	12	13

using System;

class FillTheMatrix
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int matrixSize = int.Parse(Console.ReadLine());
        int[,] matrix = new int[matrixSize, matrixSize];
        int cellValue = 1;

        //populate the matrix
        for (int cols = 0; cols < matrix.GetLength(0); cols++)
        {
            for (int rows = 0; rows < matrix.GetLength(1); rows++)
            {
                if (cols % 2 == 0)
                {
                    matrix[rows, cols] = cellValue;
                }
                else
                {
                    matrix[matrix.GetLength(0) - rows - 1, cols] = cellValue;
                }
                cellValue++;

            }
        }

        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                Console.Write("{0, 3}|", matrix[rows, cols]);
            }
            Console.WriteLine();
        }
    }
}

