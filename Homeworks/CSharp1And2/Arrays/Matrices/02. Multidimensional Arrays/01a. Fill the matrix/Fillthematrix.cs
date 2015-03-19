//Write a program that fills and prints a matrix of size (n, n) as shown below:

//1	5	9	13
//2	6	10	14
//3	7	11	15
//4	8	12	16

using System;

class Fillthematrix
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int matrixSize = int.Parse(Console.ReadLine());
        int[,] matrix = new int[matrixSize, matrixSize];
        int cellValue = 1;

        //populating the matrix - first the rows, then the columns
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                matrix[cols, rows] = cellValue;
                cellValue++;
                
            }
            
        }

        //print the matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                Console.Write("{0, 3}|", matrix[row, cols]);
            }
            Console.WriteLine();
        }
    }
}

