using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class GreedyDwarf
{
    static void Main()
    {
        int[] input = Console.ReadLine()
                              .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                              .Select(x => int.Parse(x))
                              .ToArray();
        int numberOfPatterns = int.Parse(Console.ReadLine());
        var patterns = new string[numberOfPatterns];


        for (int i = 0; i < numberOfPatterns; i++)
        {
            patterns[i] = Console.ReadLine();
        }


        var currentPattern = new List<int>();
        long maxCoins = long.MinValue;

        foreach (var pattern in patterns)
        {
            //make a copy of the original array and use it as a valey for the current pattern
            var valley = new int[input.Length];
            Array.Copy(input, valley, input.Length);

            //take current pattern
            currentPattern = pattern.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();

            long coinsCollected = 0;
            int dwarfIndex = 0;
            int startPatElement = 0;

            while (dwarfIndex >= 0 && dwarfIndex < valley.Length)
            {
                if (valley[dwarfIndex] == 0)
                {
                    break;
                }
                //collect the coins
                coinsCollected += valley[dwarfIndex];
                valley[dwarfIndex] = 0;

                //take pattern element
                int currentPatElement = startPatElement % currentPattern.Count;
                startPatElement++;

                //move dwarf
                dwarfIndex += currentPattern[currentPatElement];
            }

            if (maxCoins < coinsCollected)
            {
                maxCoins = coinsCollected;
            }
        }
        Console.WriteLine(maxCoins);

    }
}
