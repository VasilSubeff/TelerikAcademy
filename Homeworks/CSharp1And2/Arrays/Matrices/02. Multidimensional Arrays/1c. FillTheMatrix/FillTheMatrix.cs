//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
//7 11 14 16
//4 8 12 15
//2 5 9 13
//1 3 6 10

using System;

class FillTheMatrix
{
    static void Main()
    {
        int matrixSize = 4;
        int[,] matrix = new int[matrixSize, matrixSize];
        int value = 1;

        //fill the first half of the matrix, all elements to 10.
        for (int row = 0; row < matrixSize; row++)
        {
            for (int col = 0; col <= row; col++)
            {
                matrix[matrixSize - row + col - 1, col] = value++;
            }
        }
        //fill the remaining elements.
        for (int row = matrixSize - 2; row >= 0; row--)
        {
            for (int col = row; col >= 0; col--)
            {
                matrix[row - col, matrixSize - col - 1] = value++;
            }
        }
        //print out the matrix
        for (int row = 0; row < matrixSize; row++)
        {
            for (int col = 0; col < matrixSize; col++)
            {
                Console.Write("{0, -3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}