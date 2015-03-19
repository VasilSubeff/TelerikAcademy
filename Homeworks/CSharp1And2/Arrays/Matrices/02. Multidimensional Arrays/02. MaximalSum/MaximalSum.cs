//Write a program that reads a rectangular matrix of size N x M 
//and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaxSumOfThreeByThreeElements
{
    static void Main(string[] args)
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter M: ");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];
        int currentSum = 0;
        int maxSum = 0;
        int[,] maxSumMatrix = new int[3, 3]; // in this matrix we store the max sum elements.
        //fill the matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                matrix[row, col] = inputNumber;
            }
        }

        // print the matrix
        Console.WriteLine("This is the matrix !");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }

        //fint the max sum
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                             matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                             matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxSumMatrix[0, 0] = matrix[row, col];
                    maxSumMatrix[0, 1] = matrix[row, col + 1];
                    maxSumMatrix[0, 2] = matrix[row, col + 2];
                    maxSumMatrix[1, 0] = matrix[row + 1, col];
                    maxSumMatrix[1, 1] = matrix[row + 1, col + 1];
                    maxSumMatrix[1, 2] = matrix[row + 1, col + 2];
                    maxSumMatrix[2, 0] = matrix[row + 2, col];
                    maxSumMatrix[2, 1] = matrix[row + 2, col + 1];
                    maxSumMatrix[2, 2] = matrix[row + 2, col + 2];
                }
            }
        }
        //print the max sum
        Console.WriteLine("The maxsimum sum of 3x3 elements is {0} and it is the sum of the below elements!", maxSum);
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(maxSumMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

