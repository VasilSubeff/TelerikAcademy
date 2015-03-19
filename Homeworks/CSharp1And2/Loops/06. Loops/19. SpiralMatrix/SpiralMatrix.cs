//Write a program that reads from the console a positive integer number n (1 = n = 20) 
//and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.

using System;

class Spiral
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] spiral = new int[n, n];
        string direction = "right";
        int currentRow = 0;
        int currentCol = 0;
        for (int i = 1; i <= n * n; i++)
        {
            if (direction == "right" && (currentCol >= n || spiral[currentRow, currentCol] != 0))
            {
                currentCol--;
                currentRow++;
                direction = "down";
            }
            else if (direction == "down" && (currentRow >= n || spiral[currentRow, currentCol] != 0))
            {
                currentRow--;
                currentCol--;
                direction = "left";
            }
            else if (direction == "left" && (currentCol < 0 || spiral[currentRow, currentCol] != 0))
            {
                currentCol++;
                currentRow--;
                direction = "up";
            }
            else if (direction == "up" && (currentRow < 0 || spiral[currentRow, currentCol] != 0))
            {

                currentRow++;
                currentCol++;
                direction = "right";
            }

            spiral[currentRow, currentCol] = i;
            if (direction == "right")
            {
                currentCol++;
            }
            else if (direction == "down")
            {
                currentRow++;
            }
            else if (direction == "left")
            {
                currentCol--;
            }
            else if (direction == "up")
            {
                currentRow--;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0, 3}|",spiral[i, j]);

            }
            Console.WriteLine();
        }
    }
}



