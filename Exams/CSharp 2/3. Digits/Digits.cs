using System;
using System.Collections.Generic;
using System.Linq;
class Digits
{
    static void Main()
    {
        var matrix = ReadMatrix();

        bool[,] patternZero = {
                             { true, true, true },
                             { true, false, true },
                             { true, false, true },
                             { true, false, true },
                             { true, true, true }
                         };
        bool[,] patternOne ={
                            { false, false, true },
                             { false, true, true },
                             { true, false, true },
                             { false, false, true },
                             { false, false, true }
                         };
        bool[,] patternTwo = {
                             { false, true, false },
                             { true, false, true },
                             { false, false, true },
                             { false, true, false },
                             { true, true, true }
                         };
        bool[,] patternThree = {
                             { true, true, true },
                             { false, false, true },
                             { false, true, true },
                             { false, false, true },
                             { true, true, true }
                         };
        bool[,] patternFour = {
                             { true, false, true },
                             { true, false, true },
                             { true, true, true },
                             { false, false, true },
                             { false, false, true }
                         };
        bool[,] patternFive = {
                             { true, true, true },
                             { true, false, false },
                             { true, true, true },
                             { false, false, true },
                             { true, true, true }
                         };
        bool[,] patternSix = {
                             { true, true, true },
                             { true, false, false },
                             { true, true, true },
                             { true, false, true },
                             { true, true, true }
                         };
        bool[,] patternSeven = {
                             { true, true, true },
                             { false, false, true },
                             { false, true, false },
                             { false, true, false },
                             { false, true, false }
                         };
        bool[,] patternEight = {
                             { true, true, true },
                             { true, false, true },
                             { false, true, false },
                             { true, false, true },
                             { true, true, true }
                         };
        bool[,] patternNine = {
                             { true, true, true },
                             { true, false, true },
                             { false, true, true },
                             { false, false, true },
                             { true, true, true }
                         };


        List<bool[,]> patterns = new List<bool[,]>();

        patterns.Add(patternOne);
        patterns.Add(patternTwo);
        patterns.Add(patternThree);
        patterns.Add(patternFour);
        patterns.Add(patternFive);
        patterns.Add(patternSix);
        patterns.Add(patternSeven);
        patterns.Add(patternEight);
        patterns.Add(patternNine);

        int patternDigit = 0;
        var result = new List<int>();

        foreach (var pattern in patterns)
        {
            for (int patternStartX = 0; patternStartX <= matrix.GetLength(0) - pattern.GetLength(0); patternStartX++)
            {
                for (int patternStartY = 0; patternStartY <= matrix.GetLength(1) - pattern.GetLength(1); patternStartY++)
                {
                    var numbersInPattern = new List<int>();

                    for (int patternX = 0; patternX < pattern.GetLength(0); patternX++)
                    {
                        for (int patternY = 0; patternY < pattern.GetLength(1); patternY++)
                        {
                            var x = patternStartX + patternX;
                            var y = patternStartY + patternY;

                            if (pattern[patternX, patternY])
                            {
                                numbersInPattern.Add(matrix[x, y]);
                            }
                        }
                    }

                    bool foundPattern = true;

                    for (int i = 1; i < numbersInPattern.Count; i++)
                    {
                        if (numbersInPattern[i -1] != numbersInPattern[i] || numbersInPattern[i] != patternDigit)
                        {
                            foundPattern = false;
                            break;
                        }
                    }

                    if (foundPattern)
                    {
                        result.Add(patternDigit);
                    }
                }
            }

            
            patternDigit++;
        }

        int sum = 0;

        foreach (var res in result)
        {
            sum += res;
        }
        
        Console.WriteLine(sum);
        

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

