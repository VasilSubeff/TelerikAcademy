//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

using System;
using System.Collections.Generic;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {

        List<int> sameRows = new List<int>();
        List<int> diffRows = new List<int>();
        string lineFromFileOne = string.Empty;
        string lineFromFileTwo = string.Empty;
        
        using (StreamReader fileOne = new StreamReader("file1.txt"))
        {
            lineFromFileOne = fileOne.ReadLine();

            using (StreamReader fileTwo = new StreamReader("file2.txt"))
            {
                lineFromFileTwo = fileTwo.ReadLine();
                int rowCounter = 0;

                while (lineFromFileOne != null && lineFromFileTwo != null)
                {
                    rowCounter++;

                    if (lineFromFileOne.Equals(lineFromFileTwo))
                    {
                        sameRows.Add(rowCounter);
                    }
                    else
                    {
                        diffRows.Add(rowCounter);
                    }

                    lineFromFileOne = fileOne.ReadLine();
                    lineFromFileTwo = fileTwo.ReadLine();
                }
            }
        }

        Console.Write("The same rows are: ");
        
        foreach (var row in sameRows)
        {
            Console.Write(row + " ");
        }

        Console.WriteLine();

        Console.Write("The different rows are: ");
       
        foreach (var row in diffRows)
        {
            Console.Write(row + " ");
        }

        Console.WriteLine();

    }
}

