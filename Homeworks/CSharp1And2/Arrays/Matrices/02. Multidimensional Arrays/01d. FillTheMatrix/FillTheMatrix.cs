//Write a program that fills and prints a matrix of size (n, n) as shown below:
//1	12	11	10
//2	13	16	9
//3	14	15	8
//4	5	6	7

using System;

class FillTheMatrix
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int matrixSize = int.Parse(Console.ReadLine());
        int[,] matrix = new int[matrixSize, matrixSize];
        int currentRow = 0;
        int currentCol = 0;
        string direction = "down";

        for (int cellValue = 1; cellValue <= matrixSize * matrixSize; cellValue++)
        {
            if (direction == "down" &&  (currentRow >= matrixSize || matrix[currentRow, currentCol] != 0))
            {
                direction = "right";
                currentRow--;
                currentCol++;
            }
            else if (direction == "right" && (currentCol >= matrixSize || matrix[currentRow, currentCol] != 0))
            {
                direction = "up";
                currentCol--;
                currentRow--;
            }
            else if (direction == "up" && (currentRow < 0 || matrix[currentRow, currentCol] != 0))
            {
                direction = "left";
                currentRow++;
                currentCol--;
            }
            else if (direction == "left" && (currentCol < 0 || matrix[currentRow, currentCol] != 0))
            {
                direction = "down";
                currentRow++;
                currentCol++;
            }

            matrix[currentRow, currentCol] = cellValue;

            if (direction == "down")
            {
                currentRow++;
            }
            if (direction == "right")
            {
                currentCol++;
            }
            if (direction == "up")
            {
                currentRow--;
            }
            if (direction == "left")
            {
                currentCol--;
            }
        }

        //Print the matrix

        for (int rows = 0; rows < matrixSize; rows++)
        {
            for (int cols = 0; cols < matrixSize; cols++)
            {
                Console.Write("{0, 3}|", matrix[rows,cols]);
            }
            Console.WriteLine();
        }
    }
}

