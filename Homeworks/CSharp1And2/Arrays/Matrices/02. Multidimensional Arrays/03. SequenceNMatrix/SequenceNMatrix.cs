//We are given a matrix of strings of size N x M. 
//Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. 
//Write a program that finds the longest sequence of equal strings in the matrix. 
using System;
using System.Collections.Generic;



class SequenceNMatrix
{
    static void Main(string[] args)
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter M: ");
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, m];

        //fill the matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                string input = Console.ReadLine();
                matrix[row, col] = input;
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

        //scan the rows for a sequence
        List<string> sequence = new List<string>();
        List<string> maximumSequence = new List<string>();
        bool endOfSequence = false;
        int currentSequence = 0;
        int maxSequence = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {

                    currentSequence++;
                    sequence.Add(matrix[row, col]);
                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;

                        maximumSequence = new List<string>(sequence);

                    }
                    endOfSequence = true;
                }
                else if (endOfSequence)
                {

                    endOfSequence = false;
                    currentSequence = 0;
                    sequence.Clear();

                }

            }
            currentSequence = 0;
        }
        //scan the columns for a sequence.
        currentSequence = 0;
        sequence = new List<string>();
        endOfSequence = false;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    currentSequence++;
                    sequence.Add(matrix[row, col]);
                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;

                        maximumSequence = new List<string>(sequence);

                    }
                    endOfSequence = true;
                }
                else if (endOfSequence)
                {

                    endOfSequence = false;
                    currentSequence = 0;
                    sequence.Clear();

                }
            }
        }
        //scan the right for the sequence
        currentSequence = 0;
        sequence = new List<string>();
        endOfSequence = false;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int moveRow = row;
                int moveCol = col;
                while (moveRow != n - 1 || moveCol != m - 1)
                {
                    if (moveRow == n - 1 || moveCol == m - 1)
                    {
                        break;
                    }
                    if (matrix[moveRow, moveCol] == matrix[moveRow + 1, moveCol + 1])
                    {
                        currentSequence++;
                        sequence.Add(matrix[moveRow, moveCol]);

                        if (currentSequence > maxSequence)
                        {
                            maxSequence = currentSequence;

                            maximumSequence = new List<string>(sequence);

                        }
                        endOfSequence = true;
                    }
                    else if (endOfSequence)
                    {

                        endOfSequence = false;
                        currentSequence = 0;
                        sequence.Clear();
                        break;

                    }
                    else
                    {
                        break;
                    }
                    moveRow++;
                    moveCol++;

                }

            }
        }
        //scan the left diagonal
        currentSequence = 0;
        sequence = new List<string>();
        endOfSequence = false;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = matrix.GetLength(1) - 1; col >= 1; col--)
            {
                int moveRow = row;
                int moveCol = col;
                while (moveRow != n - 1 || moveCol != 0)
                {
                    if (moveRow == n - 1 || moveCol == 0)
                    {
                        break;
                    }
                    if (matrix[moveRow, moveCol] == matrix[moveRow + 1, moveCol - 1])
                    {
                        currentSequence++;
                        sequence.Add(matrix[moveRow, moveCol]);

                        if (currentSequence > maxSequence)
                        {
                            maxSequence = currentSequence;

                            maximumSequence = new List<string>(sequence);

                        }
                        endOfSequence = true;
                    }
                    else if (endOfSequence)
                    {

                        endOfSequence = false;
                        currentSequence = 0;
                        sequence.Clear();
                        break;

                    }
                    else
                    {
                        break;
                    }
                    moveRow++;
                    moveCol--;
                }
            }
        }
        //print out the max sequence 
        if (maximumSequence.Count > 0)
        {
            maximumSequence.Add(maximumSequence[0]); // add the first element again. 
            Console.Write("The longest sequnce is: ");
            for (int i = 0; i < maximumSequence.Count; i++)
            {
                Console.Write(maximumSequence[i] + " ");
            }
        }
        else
        {
            Console.WriteLine("There is no sequence");
        }
        Console.WriteLine();
    }
}

